using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace PortTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipAdress;
            int port;
            string protocol;
            Console.Write("Nhap Host IP: ");
            ipAdress = Console.ReadLine();
            Console.Write("Nhap Host Port: ");
            port = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap protocol: ");
            protocol = Console.ReadLine();

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipAdress), port);
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(ip);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Host: {0}:{1} is close", ipAdress, port);
                Console.WriteLine(ex);

            }
            Console.WriteLine("Host: {0}:{1} is open", ipAdress, port);
        }
    }
}