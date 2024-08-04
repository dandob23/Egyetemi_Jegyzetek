using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_szinek_szamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PIROS = A szám kisebb 50-nél és osztható 3-mal");
            Console.WriteLine("SÁRGA = A szám nagyobb 50-nél és osztható 5-tel");
            Console.WriteLine("ZÖLD = Egyik sem");
            Console.WriteLine("\nMost kérled add meg a számot:");
            int a = int.Parse(Console.ReadLine());
            if ((a < 50) && (a % 3 == 0))
            {
                Console.WriteLine("PIROS");
            }
            else
            {
                if ((a > 50) && (a % 5 == 0))
                {
                    Console.WriteLine("SÁRGA");
                }
                else
                {
                    Console.WriteLine("ZÖLD");
                }
            }
            Console.ReadKey();


        }
    }
}
