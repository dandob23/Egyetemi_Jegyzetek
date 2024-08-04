using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
        int x = -1;
        while (x <= 0)
            {
                Console.WriteLine("Írj be egy pozitív számot!");              
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A szám kétszerese = {0}", x*2);
            Console.ReadKey();
        }
    }
}
