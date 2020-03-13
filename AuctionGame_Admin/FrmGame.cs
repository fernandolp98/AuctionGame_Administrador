using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AuctionGame_Admin
{
    public partial class FrmGame : Form
    {
        public delegate void ClientCarrier(TcpConnection tcpConnection);
        public event ClientCarrier OnClientConnected;
        public event ClientCarrier OnClientDisconnected;
        public delegate void DataRecieved(TcpConnection tcpConnection, string data);
        public event DataRecieved OnDataRecieved;

        private TcpListener _tcpListener;
        private Thread _acceptThread;
        private readonly List<TcpConnection> _connectedClients = new List<TcpConnection>();

        private bool _serverIsOn;


        private Routine _routine;
        private decimal _initialMoney;
        private Time _initialTime;

        public FrmGame(Routine routine, decimal initialMoney, Time initialTime)
        {
            InitializeComponent();
            _serverIsOn = true;
            _routine = routine;
            _initialMoney = initialMoney;
            _initialTime = initialTime;
        }

        private void ChildMainGame_Load(object sender, EventArgs e)
        {
            OnDataRecieved += MessageReceived;
            OnClientConnected += ConnectionReceived;
            OnClientDisconnected += ConexionCerrada;

            ListenClients("127.0.0.1", 1698);
        }
        private void ConnectionReceived(TcpConnection tcpConnection)
        {
            if (_serverIsOn)
            {
                lock (_connectedClients)
                    if (!_connectedClients.Contains(tcpConnection))
                        _connectedClients.Add(tcpConnection);
                Invoke(new Action(() =>
                {
                    //Mostrar cliente conectado
                }));

                var msgPack = new Package("connectionResultOk", $"{_initialTime.Seconds}|{_routine.IdRoutine}|{_initialMoney}");
                tcpConnection.EnviarPaquete(msgPack);
            }
            else
            {
                var msgPack = new Package("connectionResultNo", "Denied");
                tcpConnection.EnviarPaquete(msgPack);
            }

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
        private void MessageReceived(TcpConnection tcpConnection, string data)
        {
            var package = new Package(data);
            var command = package.Command;
            if (command == "newBidd")//Si se realiza nueva puja
            {
                var content = package.Content;
                var values = Map.Deserialize(content); //idBidd|Oferta

                Invoke(new Action(() =>
                {
                    //Mostrar Mensaje recibido
                }));

                var msgPack = new Package("result", "OK");
                tcpConnection.EnviarPaquete(msgPack);
            }
        }

        private void ListenClients(string ipAddress, int port)
        {
            try
            {
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
            do
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
                    MessageBox.Show(e.Message);
                }
            } while (true);
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
