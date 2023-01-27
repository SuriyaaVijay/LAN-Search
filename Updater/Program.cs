using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Net.Sockets;

namespace Updater
{
    class Program
    {
        static void Main(string[] args)        
        {
            Console.WriteLine("Update Server.");
            TcpListener listener = new TcpListener(12345);
            string version;
            string message;
            string address;
            Console.WriteLine("Enter Version");
            version = Console.ReadLine();
            Console.WriteLine("Enter Message");
            message = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            listener.Start();
            Console.WriteLine("server initialized.");
            while (true)
            {
                Console.WriteLine("Waiting for"
                    + "incoming connections...");
                Socket s = listener.AcceptSocket();
                Console.WriteLine(s.RemoteEndPoint);
                NetworkStream ns = new NetworkStream(s);
                StreamWriter sw = new StreamWriter(ns);                
                sw.WriteLine(version);
                sw.WriteLine(message);
                sw.WriteLine(address);
                sw.Close();
                ns.Close();
                s.Close();
            }
        }
    }
}
