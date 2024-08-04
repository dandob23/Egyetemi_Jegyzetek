using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Ciklus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Számot kérek:");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int db = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("");
            if (db == 2)

            {
                Console.WriteLine("{0} prímszám", szam);
            }
            else
            {
                Console.WriteLine("{0} nem prímszám", szam);
            }

            Console.ReadKey();
        }
    }
}
