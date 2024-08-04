using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Configuration;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    internal class Program
    {
        static bool listen = true;
        static TcpListener server;

        private const string userFile = "Users.xml";
        private const string resourcesFile = "Resources.xml";

        static void Main(string[] args)
        {
            User.LoadUsers(userFile);
            Resource.LoadResources(resourcesFile);
            IPAddress ip = IPAddress.Parse(ConfigurationManager.AppSettings["ip"].ToString());
            int port = int.Parse(ConfigurationManager.AppSettings["port"].ToString());

            server = new TcpListener(ip, port);
            server.Start();

            new Thread(WaitForClients).Start();

            Console.WriteLine("Press enter to shut down the server...");
            Console.ReadLine();

            listen = false;
            Client.KillAllClient();
            server.Stop();
            User.SaveUsers(userFile);
            Resource.SaveResources(resourcesFile);
        }

        static void WaitForClients()
        {
            List<Thread> clientThread = new List<Thread>();
            while (listen)
            {
                if (server.Pending())
                {
                    TcpClient client = server.AcceptTcpClient();
                    //Thread t = new Thread(() => ManageClient(client));
                    //t.Start();
                    //clientThread.Add(t);

                }
            }
            foreach (var thread in clientThread) 
            {
                thread.Join();
            }
        }

        //static void ManageClient(TcpClient client)
        //{
        //    StreamReader reader = new StreamReader(client.GetStream());
        //    StreamWriter writer = new StreamWriter(client.GetStream());

        //    try
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine($"Received message: {reader.ReadLine()}");
        //            writer.WriteLine("Message received!");
        //            writer.Flush();
        //        }
        //    }
        //    catch (Exception) {}
        //    finally
        //    {
        //        reader.Close();
        //        writer.Close();
        //        client.Close();
        //        Console.WriteLine("An error has occured while listening to the client...");
        //    }
        //}
    }
}
