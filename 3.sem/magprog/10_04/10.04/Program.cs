using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Dolgozat max pontszám (10,100): ");
            string input1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------\r\n");

            Console.WriteLine("-------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Dolgozatra elért pontszám: ");
            string input2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");




            int maxpoint;
            int ownpoint;

            bool logika1 = int.TryParse(input1, out maxpoint);
            bool logika2 = int.TryParse(input2, out ownpoint);

            if (logika1 == true && maxpoint < 101 && maxpoint > 9
                && logika2 == true && ownpoint < maxpoint && ownpoint > -1)
            {
                double percentage = ((double)ownpoint / (double)maxpoint) * 100;
                double roundedPerc = Math.Round(percentage);
                if (roundedPerc < 51)
                {
                    Console.WriteLine("{0}%: elégtelen", roundedPerc);
                }
                else if (roundedPerc < 61)
                {
                    Console.WriteLine("{0}%: elégséges", roundedPerc);
                }
                else if (roundedPerc < 71)
                {
                    Console.WriteLine("{0}%: közepes", roundedPerc);
                }
                else if (roundedPerc < 81)
                {
                    Console.WriteLine("{0}%: jó", roundedPerc);
                }
                else
                {
                    Console.WriteLine("{0}%: kiváló", roundedPerc);
                }
            }



            Console.ReadKey();
        }
    }
}
