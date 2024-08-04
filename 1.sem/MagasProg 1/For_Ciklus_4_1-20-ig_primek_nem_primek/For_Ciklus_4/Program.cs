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
            for (int szam = 1; szam <= 20; szam++)
            {
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
            }

            Console.ReadKey();
        }
    }
}
