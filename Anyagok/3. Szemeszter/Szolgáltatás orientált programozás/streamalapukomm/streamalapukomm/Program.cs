using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace streamalapukomm
{
    class Program
    {
        static StreamWriter outp;
        static void Main(string[] args)
        {
            IPHostEntry addresses = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in addresses.AddressList)
                Console.WriteLine("{0}", ip);
            IPAddress ipm = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ipm, 5000);
            listener.Start();

            TcpClient client = listener.AcceptTcpClient();
            StreamReader r = new StreamReader(client.GetStream(), Encoding.UTF8);
            outp = new StreamWriter(client.GetStream(), Encoding.UTF8);
            outp.WriteLine("Welcome to Twin Peaks");
            outp.Flush();
            bool end = false;
            while (!end)
            {
                string command = r.ReadLine().ToUpper();
                string[] line = command.Split('|');
                switch (line[0])
                {
                    case "OSZT": Divide(line[1], line[2]); break;
                    case "ADD": Add(line[1], line[2]); break;
                    case "PRIM": prime(line[1]); break;
                    case "FIB": Fib(line[1]); break;
                    case "BYE": outp.WriteLine("BYE"); end = true; break;
                    default: outp.WriteLine("ERR|Unknown command"); break;
                }
                outp.Flush();
            }

            Console.ReadKey();
        }
        static void Divide(string p1, string p2)
        {
            if (int.Parse(p2) == 0)
            {
                outp.WriteLine("OK*");
                outp.WriteLine("ERR|Division by zero");
                outp.WriteLine("ERR|Very creative error code");
                outp.WriteLine("OK!");
                outp.Flush();
            }
            else
                outp.WriteLine(int.Parse(p1) / int.Parse(p2));
        }

        static void Add(string p1, string p2)
        {
            outp.WriteLine(int.Parse(p1) + int.Parse(p2));
        }

        static void Fib(string p1)
        {
            int x1 = 1, x2 = 1, temp = 0;
            if(int.Parse(p1) == 1 || int.Parse(p1) == 2)
            {
                outp.WriteLine("A {0}. fibonacci szám értéke: 1",p1);
            }
            else
            {
                for (int i = 2; i < int.Parse(p1); i++)
                {
                    temp = x1 + x2;
                    x1 = x2;
                    x2 = temp;
                }
                outp.WriteLine("A {0}. fibonacci szám értéke: {1}",p1,temp);
            }
        }

        static void prime(string num)
        {
            int n = int.Parse(num);
            outp.WriteLine("OK*");
            outp.Flush();

            for(int i = 2; i <= n; i++)
            {
                if(Prim(i))
                {
                    outp.WriteLine(i);
                    outp.Flush();
                }
            }
            outp.WriteLine("OK!");
            outp.Flush();
        }

        static bool Prim(int p1)
        {
            bool prime_e = true;
            for (int i = 2; i <= Math.Sqrt(p1) && prime_e; i++)
            {
                if (p1 % i == 0)
                    prime_e = false;
            }
            return prime_e;
        }
    }
}
