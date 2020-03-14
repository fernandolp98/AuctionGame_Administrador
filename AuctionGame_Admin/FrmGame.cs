using System;
using System.Collections.Generic;
using System.Drawing;
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
            Invoke(new Action(() =>
            {
                //Mostrar usuario cerrado
            }));
        }
        private void MessageReceived(TcpConnection tcpConnection, string data)//Mensaje recibido
        {
            var package = new Package(data);
            var command = package.Command;
            if (command == "newUser")//Se envia el nombre del nuevo usuario para ser registrado
            {
                var nameUser = package.Content;
                var query = $"SELECT insert_user('{nameUser}', {_initialMoney})";
                var userDt = DbConnection.consultar_datos(query);
                if (userDt != null)
                {
                    var user = User.GetUserById((int)userDt.Rows[0][0]);
                    var msgPack = new Package("connectionResultOk", $"{user.IdUser}|{_routine.IdRoutine}|{_initialTime.GetSeconds()}"); //Envia Paquete con la información del juego -> idUser|idRutina|Tiempo
                    tcpConnection.EnviarPaquete(msgPack);
                    Invoke(new Action(() =>
                    {
                        AddText(rtxbUsers, $"{user.NameBidder} ({user.IdBidder})", Color.Black, true);

                    }));
                }
            }
            if (command == "newBidd")
            {

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


                /////////// REINICIAR JUGADORES ///////////////// (ENVIAR MENSAJE)
                //_player.ParticipationsRound = 0;
                //_player.OutBidder = false;
                //_player.Rounds = 0;
                //_player.Offert = 0;
                //_player.LastBiddTime = DateTime.Now;

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

                    //_player.Statistics.AddRoundsForBidd(_player.Rounds);
                    //_player.Statistics.AddBiddForRound(_player.ParticipationsRound);



                    AddText(rtxbActivity, $"Termina subasta, gana {_currentWinner}. \n", Color.Blue, true);
                    timerAuction.Stop();//se detiene la variable tiempo
                    txbClock.BackColor = Color.Red;//cambia el color del reloj

                    //si el ganador es el jugador
                    //if (_currentWinner == _player.IdBidder)
                    //{
                    //    _player.ProductsEarned.Add(_currentProduct);
                    //    VerifyFamiliesEarned();
                    //    _player.Wallet = _player.Wallet - _player.Offert;// se le descuenta de su cartera el monto ofertado
                    //    _player.Points += _currentProduct.Points;
                    //    lblPoints.Text = _player.Points.ToString();
                    //    lblMoney.Text = _player.Wallet.ToString();
                    //    _player.Statistics.BidWin++;
                    //}

                    if (_virtualBidders != null)
                        for (int index = 0; index < _virtualBidders.Count(); index++) //for  para recorrer el array de bidders
                        {
                            var vb = _virtualBidders.ElementAt(index);
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
                        if (!vb.OutBidder)
                        {
                            vb.Role.OffertsForRound.GetNewFinallyValue();
                        }
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
                    //for para recalcular el tiempo de las apuestas
                    for (int index = 0; index < _virtualBidders.Count(); index++) //for  para recorrer el array de bidders
                    {
                        var vb = _virtualBidders.ElementAt(index);
                        if (vb.ParticipationsRound == 0)
                        {
                            vb.OutBidder = true;//SE CAMBIA LA VARIABLE DE BIDDER FUERA A TRUE
                        }
                        vb.ParticipationsRound = 0;//LA PARTICIPACIPON DE LA NUEVA RONDA SE CAMBIA A 0                    
                    }
                    //si el jugador no participo en la ronda anterior
                    //if (_player.ParticipationsRound == 0)
                    //{
                    //    _player.OutBidder = true;//queda fuera de la subasta
                    //}
                    //_player.Statistics.AddBiddForRound(_player.ParticipationsRound);
                    //_player.ParticipationsRound = 0;
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
                using (Semaphore semaphore = Semaphore.OpenExisting("Semaphore"))
                {
                    Thread.Sleep(vb.Role.TimeToBid.FinallyValue * 1000);

                    while (_activeAuction)
                    {
                        if (!vb.OutBidder)//si el bidder no esta fuera
                        {
                            if (_minutes != 0 || _seconds != 0)
                            {
                                semaphore.WaitOne();
                                //aumenta el tamaño de size para pasar al siguiente bidder
                                if (vb.WantToBid(_lastOffert, _currentWinner, _round))// si cambia el ultimo apostador ganador se modifican las etiquetas
                                {
                                    UpdateBidd(vb);

                                    Thread.Sleep(2000);//Le da un margen de 2 segundos entre jugadores para evitar el solapamiento
                                }
                                else
                                {

                                }
                                semaphore.Release();
                                Thread.Sleep(vb.Role.TimeToBid.NewFinallyValue() * 1000);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        private void UpdateBidd(Bidder bidder)
        {
            _currentWinner = bidder.IdBidder;
            _lastOffert = bidder.Offert;
            if (lblLastOffer.InvokeRequired)
            {
                lblLastOffer.Invoke(new MethodInvoker(delegate
                {
                    lblLastOffer.Text = _lastOffert.ToString();
                }));
            }
            else
            {
                lblLastOffer.Text = _lastOffert.ToString();
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
