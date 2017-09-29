using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = 
            string HostName = Dns.GetHostName();
            Console.WriteLine("Host Name of machine =" + HostName);
            IPAddress[] ipaddress = Dns.GetHostAddresses(HostName);
            Console.WriteLine("IP Address of Machine is");
            foreach (IPAddress ip in ipaddress)
            {
                Console.WriteLine(ip.ToString());
            }
            string hostName = "www.bing.com";
            IPAddress[] ipa = Dns.GetHostAddresses(hostName);
            Console.WriteLine("IPAddress of " + hostName + " is");
            foreach (IPAddress ipaddr in ipa)
            {
                Console.WriteLine(ipaddr);
            }

            Console.ReadKey();
        }
    }
}
