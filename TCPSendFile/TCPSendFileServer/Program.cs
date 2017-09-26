using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCPSendFileServer
{
    class Program
    {
        private static Server server;

        static void Main(string[] args)
        {
            server = new Server();
            server.startListen();
            Console.ReadKey();
        }
    }
}
