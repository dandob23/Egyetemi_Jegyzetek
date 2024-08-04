using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot:");
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("\n{0} kisebb, mint {1}", a, b);
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("\n{0} nagyobb, mint {1}", a, b);
                }
                else
                {
                    Console.WriteLine("\n{0} és {1} egyenlőek", a, b);
                }
            }
            Console.ReadKey();
        }
    }
}
