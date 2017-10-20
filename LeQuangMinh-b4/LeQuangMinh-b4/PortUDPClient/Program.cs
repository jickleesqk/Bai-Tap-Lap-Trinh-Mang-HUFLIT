using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PortUDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int portnumber = 9050;
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portnumber);
            UdpClient udps = new UdpClient(ip);

            Byte[] data = Encoding.ASCII.GetBytes("Hello");

            try
            {
                udps.Send(data, data.Length, ip);
                Console.WriteLine("Port {0} Opened", portnumber);
                udps.Receive(ref ip);
            }
            catch
            {
                Console.WriteLine("Port {0} closed", portnumber);
            }
            Console.ReadLine();
        }
    }
}
