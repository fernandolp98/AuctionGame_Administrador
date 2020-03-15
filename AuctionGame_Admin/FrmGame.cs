using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmGame : Form
    {

        public delegate void ClientCarrier(TcpConnection tcpConnection);
        public event ClientCarrier OnClientConnected;
        public event ClientCarrier OnClientDisconnected;
        public delegate void DataRecieved(TcpConnection tcpConnection, string data);
        public event DataRecieved OnDataRecieved;

        private bool _serverIsOn;
        private TcpListener _tcpListener;
        private Thread _acceptThread;
        private readonly List<TcpConnection> _connectedClients = new List<TcpConnection>();

        private bool _activeAuction;
        private readonly Routine _routine;
        private readonly decimal _initialMoney;
        private readonly Time _initialTime;

        private readonly List<Product> _products;
        private List<Family> _families;
        private readonly List<VirtualBidder> _virtualBidders;

        private readonly int _initialMinutes;
        private readonly int _initialSeconds;
        private int _predeterminatedMinutes, _predeterminatedSeconds;
        private int _seconds, _minutes;

        private int _currentProductIndex;
        private Product _currentProduct;

        private decimal _lastOffert;
        private int _roundActivity;
        private int _round;

        private int _currentWinner;

        public FrmGame(Routine routine, decimal initialMoney, Time initialTime)
        {
            InitializeComponent();
            _routine = routine;
            _initialMoney = initialMoney;
            _initialTime = initialTime;
            _initialMinutes = _initialTime.Minutes;
            _initialSeconds = _initialTime.Seconds;
            _products = _routine.AllProducts;
            _virtualBidders = routine.VirtualBidders;
            _families = _routine.Families;
        }

        private void ChildMainGame_Load(object sender, EventArgs e)
        {
            OnDataRecieved += MessageReceived;
            OnClientConnected += ConnectionReceived;
            OnClientDisconnected += ConexionCerrada;

            ListenClients("127.0.0.1", 1698);
        }

        #region Servidor TCP

        private void UpdateUsers()
        {
            rtxbUsers.Clear();
            lock (_connectedClients)
            {
                foreach (var user in _connectedClients)
                {
                    var text = $"{user.User.IdBidder} - {user.User.NameBidder}";
                    AddText(rtxbUsers, text, Color.Black, false);
                }
            }
        }
        private void ConnectionReceived(TcpConnection tcpConnection)//Conexión recibida
        {
            lock (_connectedClients)
                if (!_connectedClients.Contains(tcpConnection))
                    _connectedClients.Add(tcpConnection);
        }
        private void ConexionCerrada(TcpConnection conexionTcp)
        {
            lock (_connectedClients)
                if (_connectedClients.Contains(conexionTcp))
                {
                    var cliIndex = _connectedClients.IndexOf(conexionTcp);
                    _connectedClients.RemoveAt(cliIndex);
                }
            Invoke(new Action(UpdateUsers));

        }
        private void MessageReceived(TcpConnection tcpConnection, string data)//Mensaje recibido
        {
            var package = new Package(data);
            var command = package.Command;
            var content = Map.Deserialize(package.Content);
            if (command == "newUser")//Se recibe el nombre de usuario para ser registrado
            {
                var nameUser = content[0];
                var query = $"SELECT insert_user('{nameUser}', {_initialMoney})";
                var userDt = DbConnection.consultar_datos(query);
                if (userDt != null)
                {
                    var user = User.GetUserById((int)userDt.Rows[0][0]);
                    var contentList = new List<object>{ user.IdUser, _routine.IdRoutine, _initialTime.GetSeconds() };
                    var contentString = Map.Serialize(contentList);
                    var msgPack = new Package("connectionResultOk", contentString); //Envia Paquete con la información del juego -> idUser|idRutina|Tiempo
                    tcpConnection.User = user; 
                    tcpConnection.EnviarPaquete(msgPack);
                    Invoke(new Action(() =>
                    {
                        Invoke(new Action(UpdateUsers));
                    }));
                }
            }
            if (command == "newBidd")//Usuario realiza puja idUser|Oferta|Hora
            {
                var player = tcpConnection.User;
                var newOffer = int.Parse(content[0]);
                if (newOffer <= _lastOffert || newOffer > player.Wallet || player.OutBidder) return;
                var response = new Package("biddOk", content[0]);
                tcpConnection.EnviarPaquete(response);
                var timeBetweenBidd = DateTime.Now - player.LastBiddTime;
                player.LastBiddTime = DateTime.Now;
                var secondsBetweenBidd = timeBetweenBidd.Seconds;
                var increase = newOffer - _lastOffert;

                //se le asigna el valor del campo TxtBoxValueOffert a la variable My ofert
                player.Offert = newOffer;//Int32.Parse(TxtBoxValueOffert.Text);

                UpdateBidd(player);

                player.UpdateParticipation();// se actualiza la participacion del jugador
                player.Statistics.AddIncreaseForBidd(increase);
                player.Statistics.AddSecondsBetweenBidd(secondsBetweenBidd);
            }
        }

        private void ListenClients(string ipAddress, int port)
        {
            try
            {
                _serverIsOn = true;
                _tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
                _tcpListener.Start();
                _acceptThread = new Thread(AcceptClients);
                _acceptThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void AcceptClients()
        {
            while (_serverIsOn)
            {
                try
                {
                    var connection = _tcpListener.AcceptTcpClient();
                    var srvClient = new TcpConnection(connection)
                    {
                        ReadThread = new Thread(ReadData)
                    };
                    srvClient.ReadThread.Start(srvClient);

                    OnClientConnected?.Invoke(srvClient);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        private void ReadData(object client)
        {
            var cli = client as TcpConnection;
            var charBuffer = new List<int>();
            do
            {
                try
                {
                    if (cli == null)
                        break;
                    if (cli.StreamReader.EndOfStream)
                        break;
                    var charCode = cli.StreamReader.Read();
                    if (charCode == -1)
                        break;
                    if (charCode != 0)
                    {
                        charBuffer.Add(charCode);
                        continue;
                    }
                    if (OnDataRecieved != null)
                    {
                        var chars = new char[charBuffer.Count];
                        //Convert all the character codes to their representable characters
                        for (var i = 0; i < charBuffer.Count; i++)
                        {
                            chars[i] = Convert.ToChar(charBuffer[i]);
                        }
                        //Convert the character array to a string
                        var message = new string(chars);

                        //Invoke our event
                        OnDataRecieved(cli, message);
                    }
                    charBuffer.Clear();
                }
                catch (IOException)
                {
                    break;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                    break;
                }
            } while (true);

            OnClientDisconnected?.Invoke(cli);
        }


        #endregion

        #region Apuestas
        private void btnPlay_Click(object sender, EventArgs e)
        {
            _serverIsOn = false;
            using (var semaphore = new Semaphore(1, 1, "Semaphore"))
            {

                //else
                //    foreach (var vb in _virtualBidders)
                //    {
                //        //vb.Hilo.Resume();
                //    }
                //_firstBidd = false;
                nextBid();
                if (_virtualBidders != null)
                    foreach (var vb in _virtualBidders)
                    {
                        var thread = new Thread(() => ManagerBidder(vb));
                        vb.Hilo = thread;
                        vb.Hilo.Start();
                    }
            }
        }
        private void nextBid()
        {
            if (_products.Count > 0 && _currentProductIndex < _products.Count)
            {
                txbClock.BackColor = Color.Green;
                _seconds = _predeterminatedSeconds = _initialSeconds;
                _minutes = _predeterminatedMinutes = _initialMinutes;
                //Selecciona el siguiente producto
                _currentProduct = _products.ElementAt(_currentProductIndex);
                _currentProductIndex++;
                pboxCurrentProduct.Image = _currentProduct.ImageProduct;
                _lastOffert = _currentProduct.Price; //variables para modificar los datos de la barra de estadisticas
                _roundActivity = 0; //numero de ofertas en una ronda
                _round = 1; //numero de ronda actual
                lblLastOffer.Text = _currentProduct.Price.ToString();
                lblCurrentNameProduct.Text = _currentProduct.Name;
                AddText(rtxbActivity, $"Inicia subasta por ", Color.Black, true);
                AddText(rtxbActivity, _currentProduct.Name, Color.Red, false);
                AddText(rtxbActivity, $"\nPrecio Inicial ", Color.Black, false);
                AddText(rtxbActivity, _currentProduct.Price.ToString(), Color.Red, false);
                AddText(rtxbActivity, $"\nInicia Round 1\n", Color.Black, false);

                lblAuctionNumber.Text = _currentProductIndex.ToString();
                lblRoundNumber.Text = _round.ToString();

                _currentWinner = 0;
                if (_virtualBidders != null)
                    foreach (var vb in _virtualBidders)
                    {
                        vb.OutBidder = false;
                        vb.Offert = 0;
                        vb.ParticipationsRound = 0;
                        vb.Rounds = 0;
                    }
                _activeAuction = true;
                timerAuction.Start();


                lock (_connectedClients)
                {
                    foreach (var tcp in _connectedClients)
                    {
                        tcp.User.ParticipationsRound = 0;
                        tcp.User.OutBidder = false;
                        tcp.User.Rounds = 0;
                        tcp.User.Offert = 0;
                        tcp.User.LastBiddTime = DateTime.Now;
                        var package = new Package("game", "start");
                        tcp.EnviarPaquete(package);
                    }
                }


            }
            else
            {
                MessageBox.Show(@"Ya no existen productos por subastar");
                _activeAuction = false;
            }
        }
        private void timerAuction_Tick(object sender, EventArgs e)
        {//funcion tick que se ejecuta aca intervalo de tiempo (la tenemos en 1000 = 1 segundo)
            // codigo para controlar el cronometro

            if (_seconds == 0 && _minutes == 0)//si minutos y segundos llegana 0 se detiene el cronometro
            {
                if (_roundActivity < 2) //Cuando la actividad de la ronda es menor a 2, termina la subasta 
                {
                    lock (_connectedClients)
                    {
                        foreach (var tcp in _connectedClients)
                        {
                            tcp.User.Statistics.AddRoundsForBidd(tcp.User.Rounds);
                            tcp.User.Statistics.AddBiddForRound(tcp.User.ParticipationsRound);

                            if (_currentWinner != tcp.User.IdBidder) continue;//Verifica si el usuario es el ganador

                            tcp.User.ProductsEarned.Add(_currentProduct);//Agrega a productos ganados
                            VerifyFamiliesEarned(tcp.User);//Verifica si ha ganado una familia
                            tcp.User.Wallet -= tcp.User.Offert;// se le descuenta de su cartera el monto ofertado
                            tcp.User.Points += _currentProduct.Points;//Suma los puntos del producto actual
                            tcp.User.Statistics.BidWin++;//Aumenta las apuestas ganadas

                            //Envia mensaje al usuario para actualizar puntos y dinero
                            var content = Map.Serialize(new List<object> { tcp.User.Points, tcp.User.Wallet });
                            var package = new Package("updatePointsMoney", content);
                            tcp.EnviarPaquete(package);
                        }
                    }


                    AddText(rtxbActivity, $"Termina subasta, gana {_currentWinner}. \n", Color.Blue, true);
                    timerAuction.Stop();//se detiene la variable tiempo
                    txbClock.BackColor = Color.Red;//cambia el color del reloj

                    if (_virtualBidders == null) return;
                    foreach (var vb in _virtualBidders)
                    {
                        vb.OutBidder = false;//se cambia la variable bidder fuera a false para que continuen en la nueva subasta
                        if (vb.IdBidder == _currentWinner)//si el id del bidder es igual al registrado como ganador
                        {
                            //se le resta el monto de la offerta a su cartera
                            vb.Wallet -= vb.Offert;
                        }
                    }
                }
                else //Se inicia una nueva ronda
                {
                    AddText(rtxbActivity, $"Inicia ronda {_round + 1}\n", Color.Black, true);
                    foreach (var vb in _virtualBidders)
                    {
                        if (vb.ParticipationsRound == 0)
                        {
                            vb.OutBidder = true;//El jugador queda fuera de la ronda
                        }
                        if (!vb.OutBidder)//Si el jugador no queda fuera
                        {
                            vb.Role.OffertsForRound.GetNewFinallyValue();//Se obtiene nuevo valor de ofertas
                        }
                        vb.ParticipationsRound = 0;//Su participación se reinicia a cero
                    }
                    _roundActivity = 0;// se inicializa la actividad en la ronda
                    _round++;//se aumenta el round
                    lblRoundNumber.Text = _round.ToString();
                    if (_predeterminatedMinutes == 0)//si los minutos que se dan de manera predeterminada llegan a 0
                    {
                        if (_predeterminatedSeconds > 20)//si los segundos que se dan de manera predeterminada son mas de 20
                        {
                            _predeterminatedSeconds -= 10;//se van restando 10 segundos por ronda
                        }
                        else
                        {
                            _predeterminatedSeconds = 15;//se limita a 15 segundos la ronda
                        }
                    }
                    else if (_predeterminatedMinutes == 1)
                    {
                        _predeterminatedMinutes--;
                        _predeterminatedSeconds = 50;
                    }
                    else
                    {
                        _predeterminatedMinutes--;//disminuyen los minutos que se dan de manera predeterminada
                    }
                    //se igualan los minutos y segundos a los predeterminados
                    _minutes = _predeterminatedMinutes;
                    _seconds = _predeterminatedSeconds;

                    //si el jugador no participo en la ronda anterior

                    lock (_connectedClients)
                    {
                        foreach (var tcp in _connectedClients)
                        {
                            if (tcp.User.ParticipationsRound == 0)
                            {
                                tcp.User.OutBidder = true;//queda fuera de la subasta
                            }
                            tcp.User.Statistics.AddBiddForRound(tcp.User.ParticipationsRound);
                            tcp.User.ParticipationsRound = 0;
                        }
                    }
                }
            }
            else //Continua la ronda
            {
                //aumentar segundos
                _seconds -= 1;
                //si los segundos son -1
                if (_seconds == -1)
                {   //DISMINUYE 1 minutos
                    _minutes -= 1;
                    //regresa a 59 segundos
                    _seconds = 59;
                }
                var time = new Time(0, _minutes, _seconds);
                txbClock.Text = time.Format("mm:ss");

            }
        }
        private void ManagerBidder(VirtualBidder vb)
        {
            try
            {
                using (var semaphore = Semaphore.OpenExisting("Semaphore"))
                {
                    Thread.Sleep(vb.Role.TimeToBid.FinallyValue * 1000);

                    while (_activeAuction)
                    {
                        if (vb.OutBidder) continue;
                        if (_minutes == 0 && _seconds == 0) continue;
                        semaphore.WaitOne();
                        //aumenta el tamaño de size para pasar al siguiente bidder
                        if (vb.WantToBid(_lastOffert, _currentWinner, _round))// si cambia el ultimo apostador ganador se modifican las etiquetas
                        {
                            UpdateBidd(vb);

                            Thread.Sleep(2000);//Le da un margen de 2 segundos entre jugadores para evitar el solapamiento
                        }
                        semaphore.Release();
                        Thread.Sleep(vb.Role.TimeToBid.NewFinallyValue() * 1000);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        private void VerifyFamiliesEarned(User player)
        {
            foreach (var family in _families)
            {
                var productsEarnedCount = 0;
                foreach (var productEarned in player.ProductsEarned)
                {
                    foreach (var productNeccesary in family.Products)
                    {
                        if (productNeccesary.Equals(productEarned))
                            productsEarnedCount++;
                    }
                }

                if (productsEarnedCount != family.Products.Count) continue;
                player.Points += family.Points;
            }
        }
        private void UpdateBidd(Bidder bidder)
        {
            _currentWinner = bidder.IdBidder;
            _lastOffert = bidder.Offert;
            var content = Map.Serialize(new List<object> {_currentWinner, _lastOffert});
            var package = new Package("updateBidd", content);
            SendPackage(package);
            if (lblLastOffer.InvokeRequired)
            {
                lblLastOffer.Invoke(new MethodInvoker(delegate
                {
                    lblLastOffer.Text = _lastOffert.ToString(CultureInfo.InvariantCulture);
                }));
            }
            else
            {
                lblLastOffer.Text = _lastOffert.ToString(CultureInfo.InvariantCulture);
            }
            if (lblCurrentWinner.InvokeRequired)
            {
                lblCurrentWinner.Invoke(new MethodInvoker(delegate
                {
                    lblCurrentWinner.Text = _currentWinner.ToString();
                }));
            }
            else
            {
                lblCurrentWinner.Text = _currentWinner.ToString();
            }
            _roundActivity++;
            var newPuja = bidder.IdBidder + " : " + _lastOffert + "\n";
            AddText(rtxbActivity, newPuja, Color.Red, true);
        }

        private void SendPackage(Package package)
        {
            lock (_connectedClients)
            {
                foreach (var tcp in _connectedClients)
                {
                    tcp.EnviarPaquete(package);
                }
            }
        }


        #endregion

        [Obsolete]
        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            _activeAuction = false;
            _serverIsOn = false;
            _acceptThread.Suspend();
            _tcpListener.Stop();
        }

        protected virtual void AddText_Update(RichTextBox rtxb, string text, Color color, bool hora)
        {
            rtxb.SelectionStart = rtxb.TextLength;
            rtxb.SelectionColor = color;
            rtxb.AppendText(hora ? $@"{DateTime.Now:HH:mm:ss} -> {text} " : $"{text}");
            rtxb.ScrollToCaret();
        }
        private void AddText(RichTextBox rtxb, string text, Color color, bool hora)//Rtxb, texto a agregar, color del texto, define si llevará hora
        {
            if (rtxb.InvokeRequired)
            {
                rtxb.Invoke(new MethodInvoker(delegate { AddText_Update(rtxb, text, color, hora); }));
            }
            else
            {
                AddText_Update(rtxb, text, color, hora);
            }
        }


    }
}
