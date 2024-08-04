using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Kiir(x);
            x = Szamol(x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static void Kiir(int x)
        {
            Console.WriteLine(x);
            x = 25;
        }
        static int Szamol(int x)
        {
            x = x * 2;
            return x;
        }
    }
}
