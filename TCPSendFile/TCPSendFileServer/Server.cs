using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TCPSendFileServer
{
    class Server
    {
        private Socket serverSock;      
        private Socket clientSock;      
        private byte[] dataToSend;
        private byte[] dataToReceive;
        private byte signalFromDataReceived;

        public Server()
        {
            Console.WriteLine("Server Initializing...");

            serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);   
            serverSock.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3814));   
                                                                  
            dataToSend = new byte[1024];     
            dataToReceive = new byte[1];        
        }

        public void startListen()
        {
            
            serverSock.Listen(10);
            Console.WriteLine("Server listening...");
            clientSock = serverSock.Accept();
            Console.WriteLine("Server accepted a client...");

            clientSock.Receive(dataToReceive);
            signalFromDataReceived = dataToReceive[0];      

            if (signalFromDataReceived == 1)    
            {
                clientSock.Send(new byte[1] { 1 });    
                Console.WriteLine("Server sending file to client...");
                sendFile();     
            }
        }

        private void sendFile()
        {
            
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                string line;
               
                while ((line = sr.ReadLine()) != null)
                {
                    clientSock.Receive(dataToReceive);
                    signalFromDataReceived = dataToReceive[0];     

                    if (signalFromDataReceived == 0)
                    {
                        dataToSend = Encoding.ASCII.GetBytes(line);
                        clientSock.Send(dataToSend, line.Length, SocketFlags.None);
                    }
                }
            }
        }
    }
}