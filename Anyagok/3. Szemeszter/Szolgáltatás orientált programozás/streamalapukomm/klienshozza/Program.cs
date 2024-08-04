using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace klienshozza
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            StreamReader reader = new StreamReader(client.GetStream(), Encoding.UTF8);
            StreamWriter writer = new StreamWriter(client.GetStream(), Encoding.UTF8);
            string message = reader.ReadLine();
            Console.WriteLine(message);

            bool end = false;
            while (!end)
            {
                string command = Console.ReadLine();
                writer.WriteLine(command);
                writer.Flush();
                string answer = reader.ReadLine();
                Console.WriteLine(answer);
                if (answer == "OK*")
                {
                    while (answer != "OK!")
                    {
                        answer = reader.ReadLine();
                        Console.WriteLine(answer);
                    }
                }
                if (answer == "BYE")
                    end = true;
            }

        }
    }
}
