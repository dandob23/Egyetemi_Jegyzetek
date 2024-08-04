using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Paros_Paratlan_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot: ");
            int n = int.Parse(Console.ReadLine());
            bool fut = true;
            while (fut)
            {
                if (n % 2 == 0)
                    Console.WriteLine("{0} páros", n);
                else
                    Console.WriteLine("{0} páratlan", n);
                Console.WriteLine("\nKérek egy számot: ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                    fut = false;
            }
        }
    }
}
