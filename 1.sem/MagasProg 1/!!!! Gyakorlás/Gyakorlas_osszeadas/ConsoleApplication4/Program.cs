using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;
            Console.WriteLine("Írj be 10 számot, én majd összeadom őket!");
            for (int i = 0; i < 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                osszeg = osszeg + x;
            }
            Console.WriteLine("Összeg = {0}", osszeg);
            Console.ReadKey();
        }
    }
}