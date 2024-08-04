using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemelyi_Szam_Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a személyi számod:");
            int sz = int.Parse(Console.ReadLine());
            int nap = sz % 100;
            sz = sz / 100;
            int ho = sz % 100;
            sz = sz / 100;
            int ev = sz % 100;
            int nem = sz / 100;
            ev = ev + 1900;
            int eletkor = DateTime.Now.Year - ev;
            if (ho > DateTime.Now.Month) eletkor = eletkor --;
            if (ho == DateTime.Now.Month && nap > DateTime.Now.Day) eletkor--;

            Console.WriteLine("\nKorod: {0}", eletkor);

                if ((eletkor < 18) && (nem == 1))
            {
                Console.WriteLine("Te egy kiskorú fiú vagy!");
            }
            else
                    if ((eletkor >= 18) && (nem == 1))
            {
                    Console.WriteLine("Te egy nagykorú fiú vagy!");
            }
            else
                        if ((eletkor < 18) && (nem == 2))
            {
                        Console.WriteLine("Te egy kiskorú lány vagy!");
            }
            else
                            if ((eletkor >= 18) && (nem == 2))
            {
                            Console.WriteLine("Te egy nagykorú lány vagy!");
            }
            Console.ReadKey();
        }
    }
}
