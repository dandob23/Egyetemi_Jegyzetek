using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_V
{
    class Program
    {

        static void Ellenor(string a, string b)
        {
            if (a.Length > b.Length)
            {
                Console.WriteLine("Az első szöveg hosszabb.");
            }
            else
            {
                if (a.Length < b.Length)
                {
                    Console.WriteLine("A második szöveg hosszabb.");

                }
                else
                {
                    Console.WriteLine("A két szöveg hossza megegyezik.");
                }
            }
        }
        static void Main(string[] args)
        {
            string egyik_szoveg, masik_szoveg;
            Console.WriteLine("Kérek egy szöveget: ");
            egyik_szoveg = (Console.ReadLine());
            Console.WriteLine("Kérek egy másik szöveget: ");
            masik_szoveg = (Console.ReadLine());

            /* Console.WriteLine(egyik_szoveg+masik_szoveg);*/

            Ellenor(egyik_szoveg, masik_szoveg);

            Console.ReadKey();



        }
    }
}
