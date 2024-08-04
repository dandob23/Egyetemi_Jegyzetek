using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04_12
{
    internal class Program
    {
        public static void Beolvas(IngatlanIroda iroda, string fajlnev)
        {
            StreamReader sr = new StreamReader(fajlnev);

            while (!sr.EndOfStream)
            {
                string[] adatok=sr.ReadLine()
            }
        }

        static void Main(string[] args)
        {

            

            Console.ReadKey();
        }
    }
}
