using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace AuctionGame_Admin
{
    public class TcpConnection
    {
        public TcpClient TcpClient;
        public StreamReader StreamReader;
        public StreamWriter StreamWriter;
        public Thread ReadThread;

        public delegate void DataCarrier(string data);
        public event DataCarrier OnDataRecieved;

        public delegate void DisconnectNotify();
        public event DisconnectNotify OnDisconnect;

        public delegate void ErrorCarrier(Exception e);
        public event ErrorCarrier OnError;

        public User User { get; set; }

        public TcpConnection(TcpClient client)
        {
            var networkStream = client.GetStream();
            StreamReader = new StreamReader(networkStream);
            StreamWriter = new StreamWriter(networkStream);
            TcpClient = client;
        }
        private void EscribirMsj(string mensaje)
        {
            try
            {
                StreamWriter.Write(mensaje + "\0");
                StreamWriter.Flush();
            }
            catch (Exception e)
            {
                OnError?.Invoke(e);
            }
        }
        public void EnviarPaquete(Package package)
        {
            EscribirMsj(package);
        }
    }
}
