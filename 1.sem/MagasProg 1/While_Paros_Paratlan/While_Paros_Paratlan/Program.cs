using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Paros_Paratlan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot: ");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if (n % 2 == 0)
                    Console.WriteLine("{0} páros", n);
                else
                    Console.WriteLine("{0} páratlan", n);
                Console.WriteLine("\nKérek egy számot: ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
