using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCPSenFileClient
{
    class Program
    {
        private Socket clientSock;
        byte[] dataToSend;
        byte[] dataToReceive;
        public Program()
        {
            clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSock.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3814));
            clientSock.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3814));
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
