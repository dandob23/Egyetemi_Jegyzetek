using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_DolgozatokPontok
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kérjük be az osztály létszámát, a dolgozat max pontszámát, 
            // majd a gyerekek elért pontszámát, határozzuk meg az érdemegyjet, a százalélkot
            // valamint az átlagot. 

            // ciklus: addig próbálkozom az adatok bekérésével, amíg helyes értéket nem ír 
            // be a felhasználó 
            // do-while: pozitív vezérlésű, hátultesztelő 
            // pozitív vezérlésű: akkor van ismétlétlés, ha a vezérlő feltétel értéke igaz 
            // hátulteszelő: végrehajtom a ciklusmagot, majd megvizsgálom, hogy úrja végre kell-e hajtani
            //do
            //{
            /*ciklusmag: az utasítások amelyeket ismételni kell */
            //}
            //while (/*vezérlőfeltétel: kell e ismételni?*/);

            int letszam; // deklarálok egy segédváltozót, amelyben eltárolom a létszámot
            do
            {
                Console.Write("Kérem az osztály létszámát: "); // tájékoztató üzenet 
            }
            while (
                !(int.TryParse(Console.ReadLine(), out letszam) &&
                  0 < letszam)
            );
            // 1) fejben átforudítják a feltételt: De Morgan azonosságok 
            // 2) bármilyen logikai kifejezés elé ! jelet írok, akkor az ellentétére fordul 

            // dolgozat max pontszáma
            int maxPont;
            do
            {
                Console.Write("Kérem a dolgozat max pontszámát! Pontszám: ");
            }
            while (!int.TryParse(Console.ReadLine(), out maxPont) || maxPont <= 0);

            Console.WriteLine("A(z) {0} maxpontszámú dolgoaztot {1} tanuló írta meg.", maxPont, letszam);
            // letszam mennyiségű int típusú adatot kell bekérni a [0;maxPont] intervallumról 
            // while: előltesztelő, pozitív vezérlésű; előltesztelő: először kiértékelem a feltételt és
            // eldöntöm végre kell-e hajtani a ciklusmagot 
            // while( /*verzérlőfeltétel*/){ /* ciklusmag*/}

            int i = 0; // ciklusváltozó, amellyel számolom, hogy hányszor futott le a ciklusmag 
            while(i < letszam)
            {
                // a) bekérés do-while ciklus segítségével 
                int elertPont;
                do
                {
                    Console.Write("Kérem a {0}. tanuló által elért pontot: ", i + 1);
                }
                while (!int.TryParse(Console.ReadLine(), out elertPont) || elertPont < 0 || maxPont < elertPont);
                // b) ciklusváltozó növelése 1-gyel 
                // FONTOS! A ciklusmag hatással van a vezérlő feltételre 
                i++; // i = i + 1;
            }






            Console.ReadKey();
        }






    }
}
