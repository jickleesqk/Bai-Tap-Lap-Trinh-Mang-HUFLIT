using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PortUDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 9050);
            UdpClient udpr = new UdpClient(ip);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

            Byte[] data = new Byte[1024];

            Console.WriteLine("Waiting for client ...");

            data = udpr.Receive(ref sender);
            Console.WriteLine("Message : {0}", Encoding.ASCII.GetString(data));
            /*
            while(true)
            {
                data = udpr.Receive(ref sender);
                Console.WriteLine("Message : {0}", Encoding.ASCII.GetString(data));
                udpr.Send(data, data.Length,sender);
            }
             */
            Console.ReadLine();
        }
    }
}
