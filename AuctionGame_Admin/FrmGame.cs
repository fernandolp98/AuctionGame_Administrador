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
        private readonly List<Family> _families;
        private readonly List<VirtualBidder> _virtualBidders;

        private readonly int _initialMinutes;
        private readonly int _initialSeconds;
        private int _predeterminatedMinutes, _predeterminatedSeconds;
        private int _seconds, _minutes;

        private int _currentProductIndex;
        private Product _currentProduct;

        private decimal _lastBid;
        private int _roundActivity;
        private int _round;
        private int _currentAuction;

        private int _currentWinner;

        private readonly FrmGameConfiguration _father;

        public FrmGame(Routine routine, decimal initialMoney, Time initialTime, FrmGameConfiguration father)
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
            _father = father;
            _currentAuction = 0;

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
            if (_serverIsOn)
            {
                lock (_connectedClients)
                    if (!_connectedClients.Contains(tcpConnection))
                        _connectedClients.Add(tcpConnection);
            }
            else
            {
                var contentList = new List<object> { false, "El servidor no acepta nuevas conexiones" };
                var contentString = Map.Serialize(contentList);
                var msgPack = new Package("connectionResult", contentString);
                tcpConnection.EnviarPaquete(msgPack);
            }

        }
        private void ConexionCerrada(TcpConnection conexionTcp)
        {
            try
            {
                lock (_connectedClients)
                    if (_connectedClients.Contains(conexionTcp))
                    {
                        var cliIndex = _connectedClients.IndexOf(conexionTcp);
                        _connectedClients.RemoveAt(cliIndex);
                    }
                Invoke(new Action(UpdateUsers));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private void MessageReceived(TcpConnection tcpConnection, string data)//Mensaje recibido
        {
            var package = new Package(data);
            var command = package.Command;
            switch (command)
            {
                case "newConnection":
                    NewConnection(tcpConnection, package.Content);
                    break;
                case "newBid":
                    NewBid(tcpConnection, package.Content);
                    break;
                default: 
                    Console.WriteLine($@"Se recibió mensaje con comando desconocido: {command}");
                    break;

            }
        }
        private void NewConnection(TcpConnection tcpConnection, string content)
        {
            if (_serverIsOn)
            {
                var values = Map.Deserialize(content);
                var nameUser = values[0];
                var query = $"SELECT insert_user('{nameUser}', {_initialMoney})";
                var userDt = DbConnection.consultar_datos(query);
                if (userDt != null)
                {
                    var user = User.GetUserById((int)userDt.Rows[0][0]);
                    var contentList = new List<object> { true, user.IdUser, _routine.IdRoutine, _initialTime.GetSeconds() };
                    var contentString = Map.Serialize(contentList);
                    var msgPack = new Package("connectionResult", contentString); 
                    tcpConnection.User = user;
                    tcpConnection.EnviarPaquete(msgPack);
                    Invoke(new Action(() =>
                    {
                        Invoke(new Action(UpdateUsers));
                    }));
                }
                else
                {
                    var contentList = new List<object> { false, "¡Ocurrió un problema al registrar el usuario!" };
                    var contentString = Map.Serialize(contentList);
                    var msgPack = new Package("connectionResult", contentString);
                    tcpConnection.EnviarPaquete(msgPack);

                }
            }
            else
            {
                var contentList = new List<object> { false, "El servidor no acepta nuevas conexiones" };
                var contentString = Map.Serialize(contentList);
                var msgPack = new Package("connectionResult", contentString);
                tcpConnection.EnviarPaquete(msgPack);
            }
        }

        private void NewBid(TcpConnection tcpConnection, string content)
        {
            var player = tcpConnection.User;
            var values = Map.Deserialize(content);
            var newBid = int.Parse(values[0]);
            var contentList = new List<object>();

            if (!_activeAuction)
            {
                contentList.Add(false);
                contentList.Add("No hay una subasta activa.");
            }
            else if (player.OutBidder)
            {
                contentList.Add(false);
                contentList.Add("Estás fuera de la subasta actual.");
            }
            else if (newBid <= _lastBid)
            {
                contentList.Add(false);
                contentList.Add("La oferta es menor o igual a la oferta actual.");
            }
            else if (newBid > player.Wallet)
            {
                contentList.Add(false);
                contentList.Add("La oferta es mayor a sus fondos disponibles.");
            }
            else
            {
                contentList.Add(true);
                contentList.Add(values[0]);
                player.UpdateParticipation(_lastBid, newBid);
                UpdateBid(player);
            }
            var contentString = Map.Serialize(contentList);
            var response = new Package("bidResult", contentString);
            tcpConnection.EnviarPaquete(response);

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
            using (new Semaphore(1, 1, "Semaphore"))
            {
                NextBid();
                if (_virtualBidders == null) return;
                foreach (var vb in _virtualBidders)
                {
                    var thread = new Thread(() => ManagerBidder(vb));
                    vb.Hilo = thread;
                    vb.Hilo.Start();
                }
            }
        }
        private void NextBid()
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
                _lastBid = _currentProduct.Price; //variables para modificar los datos de la barra de estadisticas
                _roundActivity = 0; //numero de ofertas en una ronda
                _round = 1; //numero de ronda actual
                _currentAuction++;
                lblLastOffer.Text = _currentProduct.Price.ToString();
                lblCurrentNameProduct.Text = _currentProduct.Name;
                AddText(rtxbActivity, $"Inicia subasta por ", Color.Black, true);
                AddText(rtxbActivity, _currentProduct.Name, Color.Red, false);
                AddText(rtxbActivity, $"\nPrecio Inicial ", Color.Black, false);
                AddText(rtxbActivity, _currentProduct.Price.ToString(CultureInfo.InvariantCulture), Color.Red, false);
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
                var contentList = new List<object> { _currentAuction, _currentProduct.IdProduct};
                var contentString = Map.Serialize(contentList);

                lock (_connectedClients)
                {
                    foreach (var tcp in _connectedClients)
                    {
                        tcp.User.ParticipationsRound = 0;
                        tcp.User.OutBidder = false;
                        tcp.User.Rounds = 0;
                        tcp.User.Offert = 0;
                        tcp.User.LastBiddTime = DateTime.Now;
                        tcp.EnviarPaquete(new Package("newAuction", contentString));
                    }
                }
                _activeAuction = true;
                timerAuction.Start();
            }
            else
            {
                MessageBox.Show(@"Ya no existen productos por subastar");
                _activeAuction = false;
            }
        }
        private void timerAuction_Tick(object sender, EventArgs e)
        {
            if (_seconds == 0 && _minutes == 0)//Cuando el tiempo llega a 00:00
            {
                if (_roundActivity < 2)//Si la actividad de la última ronda es menor a 2, finaliza la subasta
                {
                    //Actualiza estadísticas de usuario y les manda mensaje de subasta finalizada
                    lock (_connectedClients)
                    {
                        foreach (var tcp in _connectedClients)
                        {

                            tcp.User.Statistics
                                .AddRoundsForAuction(tcp.User
                                    .Rounds); //Agrega las rondas en las que participó el usuario
                            tcp.User.Statistics.AddBidByRound(tcp.User
                                .ParticipationsRound); //Agrega las ofertas por round en las que participo

                            if (_currentWinner == tcp.User.IdBidder) //Si el jugador actual es el ganador
                            {
                                tcp.User.ProductsEarned
                                    .Add(_currentProduct); //Agrega a productos ganados el producto actual
                                VerifyFamiliesEarned(tcp.User); //Verifica si se completó una familia de productos
                                tcp.User.Wallet -= tcp.User.Offert; // se le descuenta de su cartera el monto ofertado
                                tcp.User.Points += _currentProduct.Points; //Suma los puntos del producto actual
                                tcp.User.Statistics.BidWin++; //Aumenta las apuestas ganadas

                                //Envia mensaje al usuario para actualizar puntos y dinero
                                var content = Map.Serialize(new List<object> {true, tcp.User.Points, tcp.User.Wallet});
                                tcp.EnviarPaquete(new Package("auctionFinished", content));
                            }
                            else //Si el jugador no es ganador
                            {
                                //Envía mensaje al usuario de subasta finalizada
                                var content = Map.Serialize(new List<object>
                                    {false, tcp.User.Wallet, _currentProduct.IdProduct});
                                tcp.EnviarPaquete(new Package("auctionFinished", content));
                            }
                        }
                    }
                    AddText(rtxbActivity, $"Termina subasta, gana {_currentWinner}. \n", Color.Blue, true);//Muestra mensaje en el log
                    timerAuction.Stop();//Detiene el cronómetro
                    txbClock.BackColor = Color.Red;//Cambia el color del reloj

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


                    _roundActivity = 0;// se reinicia la actividad en la ronda en cero
                    _round++;//se aumenta el round
                    lblRoundNumber.Text = _round.ToString();//Actualiza la etiqueta de la ronda

                    //Muestra en el log que se ha iniciado una nueva ronda
                    AddText(rtxbActivity, $"Inicia ronda {_round}\n", Color.Black, true);

                    //Envía mensaje a los usuarios para actualizar la ronda
                    SendPackage(new Package("newRound", (_round).ToString()));

                    //Actualiza los jugadores virtuales
                    foreach (var vb in _virtualBidders)//Recorre los jugadores virtuales
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
                    //Actualiza los usuario para la siguiente ronda
                    lock (_connectedClients)
                    {
                        foreach (var tcp in _connectedClients)
                        {
                            if (!tcp.User.OutBidder)
                            {
                                if (tcp.User.ParticipationsRound == 0)//Si no tuvo participaciones en la ronda anterior
                                {
                                    tcp.User.OutBidder = true;//queda fuera de la subasta
                                    tcp.EnviarPaquete(new Package("outBidder", "True"));//Envia mensaje al jugador
                                }
                                tcp.User.Statistics.AddBidByRound(tcp.User.ParticipationsRound);
                                tcp.User.ParticipationsRound = 0;
                            }
                        }
                    }

                    //Actualiza el tiempo predeterminado para la ronda
                    switch (_predeterminatedMinutes)
                    {
                        case 0 when _predeterminatedSeconds > 30: //Cuando los minitos son cero y los segundos mayor a 30
                            _predeterminatedSeconds -= 10;//se van restando 10 segundos por ronda
                            break;
                        case 0: //Cuando los minutos son cero
                            _predeterminatedSeconds = 20;//se limita a 20 segundos la ronda
                            break;
                        case 1: //Cuando los minutos son 1
                            _predeterminatedMinutes = 0; //Minutos quedan en cero
                            _predeterminatedSeconds = 50; //Segundos quedan en 50
                            break;
                        default: //Cuando es mayor a un minuto
                            _predeterminatedMinutes--;//disminuyen los minutos que se dan de manera predeterminada
                            break;
                    }
                    //se igualan los minutos y segundos a los predeterminados
                    _minutes = _predeterminatedMinutes;
                    _seconds = _predeterminatedSeconds;
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
                SendPackage(new Package("updateClock", time.Format("mm:ss")));

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
                        if (vb.WantToBid(_lastBid, _currentWinner, _round))// si cambia el ultimo apostador ganador se modifican las etiquetas
                        {
                            UpdateBid(vb);

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
        private void UpdateBid(Bidder bidder)
        {
            _currentWinner = bidder.IdBidder;
            _lastBid = bidder.Offert;
            var content = Map.Serialize(new List<object> {_currentWinner, _lastBid});
            var package = new Package("updateBidd", content);
            SendPackage(package);
            if (lblLastOffer.InvokeRequired)
            {
                lblLastOffer.Invoke(new MethodInvoker(delegate
                {
                    lblLastOffer.Text = _lastBid.ToString(CultureInfo.InvariantCulture);
                }));
            }
            else
            {
                lblLastOffer.Text = _lastBid.ToString(CultureInfo.InvariantCulture);
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
            var newPuja = bidder.IdBidder + " : " + _lastBid + "\n";
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
            _father?.Show();
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
