using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace DHCPServer
{
    class Program
    {
        static void Main(string[] args)
        {

            IPAddress[] ippool = new IPAddress[5];
            int r;
            Random rd = new Random();
            for (int i = 0; i < ippool.Length; i++)
            {
                ippool[i] = IPAddress.Parse("192.168.1." + (i + 10).ToString());
            }
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            UdpClient udpserver = new UdpClient(ipep);

            Console.WriteLine("Waiting for a client...");

            Byte[] data = new Byte[1024];
            data = udpserver.Receive(ref ipep);
            if (Encoding.ASCII.GetString(data) == "req")
            {
                r = rd.Next(0, ippool.Length);
                udpserver.Send(Encoding.ASCII.GetBytes(ippool[r].ToString()), ippool[r].ToString().Length, ipep);
                Console.WriteLine("IP sent");
            }
            data = new Byte[1024];
            data = udpserver.Receive(ref ipep);
            if (Encoding.ASCII.GetString(data) == "ack")
            {
                udpserver.Send(Encoding.ASCII.GetBytes("fin"), 3, ipep);
                Console.WriteLine("Finish DHCP for client");
            }
            Console.ReadLine();
        }
    }
}
