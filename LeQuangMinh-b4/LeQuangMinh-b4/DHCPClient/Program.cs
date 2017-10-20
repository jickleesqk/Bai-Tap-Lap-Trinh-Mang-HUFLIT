using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace DHCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            UdpClient udpr = new UdpClient();

            Byte[] data = new Byte[1024];
            string req = "req";
            data = Encoding.ASCII.GetBytes(req);
            udpr.Send(data, data.Length, ip);

            data = new Byte[1024];
            data = udpr.Receive(ref ip);

            if (Encoding.ASCII.GetString(data).Length > 10)
            {
                Console.WriteLine(Encoding.ASCII.GetString(data));
                data = new Byte[1024];
                string ack = "ack";
                data = Encoding.ASCII.GetBytes(ack);
                udpr.Send(data, data.Length, ip);
            }
            data = new Byte[1024];
            data = udpr.Receive(ref ip);
            if (Encoding.ASCII.GetString(data) == "fin")
            {
                Console.WriteLine("IP received!");
            }
            Console.ReadLine();
        }
    }
}

