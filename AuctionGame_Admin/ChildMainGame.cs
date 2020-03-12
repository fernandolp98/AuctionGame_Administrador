using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class ChildMainGame : Form
    {
        public delegate void ClientCarrier(TcpConnection tcpConnection);
        public event ClientCarrier OnClientConnected;
        public event ClientCarrier OnClientDisconnected;
        public delegate void DataRecieved(TcpConnection tcpConnection, string data);
        public event DataRecieved OnDataRecieved;

        private TcpListener _tcpListener;
        private Thread _acceptThread;
        private readonly List<TcpConnection> _connectedClients = new List<TcpConnection>();
        public ChildMainGame()
        {
            InitializeComponent();
        }

        private void ChildMainGame_Load(object sender, EventArgs e)
        {
            OnDataRecieved += MensajeRecibido;
            OnClientConnected += ConexionRecibida;
            OnClientDisconnected += ConexionCerrada;

            EscucharClientes("127.0.0.1", 1698);
        }
        private void MensajeRecibido(TcpConnection conexionTcp, string datos)
        {
            var paquete = new Package(datos);
            string comando = paquete.Comando;
            if (comando == "usuario")
            {
                string contenido = paquete.Contenido;
                List<string> valores = Map.Deserializar(contenido);

                Invoke(new Action(() =>
                {
                    //Mostrar Mensaje recibido
                }));

                var msgPack = new Package("resultado", "OK");
                conexionTcp.EnviarPaquete(msgPack);
            }
        }

        private void ConexionRecibida(TcpConnection conexionTcp)
        {
            lock (_connectedClients)
                if (!_connectedClients.Contains(conexionTcp))
                    _connectedClients.Add(conexionTcp);
            Invoke(new Action(() =>
            {
                //Mosstrar cliente conectado
            }));
        }

        private void ConexionCerrada(TcpConnection conexionTcp)
        {
            lock (_connectedClients)
                if (_connectedClients.Contains(conexionTcp))
                {
                    int cliIndex = _connectedClients.IndexOf(conexionTcp);
                    _connectedClients.RemoveAt(cliIndex);
                }
            Invoke(new Action(() =>
            {
                //Mostrar usuario cerrado
            }));
        }

        private void EscucharClientes(string ipAddress, int port)
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
                _tcpListener.Start();
                _acceptThread = new Thread(AceptarClientes);
                _acceptThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void AceptarClientes()
        {
            do
            {
                try
                {
                    var conexion = _tcpListener.AcceptTcpClient();
                    var srvClient = new TcpConnection(conexion)
                    {
                        ReadThread = new Thread(LeerDatos)
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

        private void LeerDatos(object client)
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
    }
}
