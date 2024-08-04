using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002_Osszegzes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Olvassunk be a konzolról egész számokat mindaddig amíg azok 
            // összege el nem éri az 1000-et. A program végén írjuk ki, hogy 
            // hány beolvasás zajlott le. 

            // ciklus kell-e? biztosan, mert benne van az mindaddig amíg szó
            // milyen ciklus kell? do-while, mivel legalább egy beolvasás kell 
            int osszeg = 0;
            int db = 0; // ebbe számolom meg a beolvasások számát
            do
            {
                Console.Write("Kérek egy egész számot: ");
                int szam; // ebben tárolom az aktuálisan beolvasott számot 
                if(int.TryParse(Console.ReadLine(), out szam))
                {
                    osszeg += szam;  // => osszeg = osszeg + szam
                }
                db++; // minden beolvasás számít, nem csak a sikeresek 
            }
            while (osszeg < 1000);
            Console.WriteLine("{0} beolvasással {1} összeget képeztünk.", db, osszeg);


            Console.ReadKey();
        }
    }
}




