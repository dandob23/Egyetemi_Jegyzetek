using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Alprogramok
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 5, -10, 100, 8 };
            int[] b = new int[] { 8, 12, 19, -1000, -100, 23, 45 };
            
            // a elemeinek kiírása
            Console.Write("Tömb elemei: ");
            for (int i = 0; i < a.Length - 1; i++)
                Console.Write("{0}, ", a[i]);
            Console.WriteLine("{0}", a[a.Length - 1]);

            // b elemeinek kiírása 
            Console.Write("Tömb elemei: ");
            for (int i = 0; i < b.Length - 1; i++)
                Console.Write("{0}, ", b[i]);
            Console.WriteLine("{0}", b[b.Length - 1]);

            // a tömb kiírásának algoritmusa azonos, csak a kiírni kívánt
            // adathalmaz (változót) változik meg 
            // alprogramok => 1) eljárás: végrehajtja a feladatát, de nem közvetít értéket a hívás helyére (C.W, C.WL)
            //                2) függvény: végrehajtja a feladatát, és visszatérési értékkkel szolgál (Parse, C.RL)

            // példa függvényre: a visszatérési értéke egy változóba kerül, vagy pedig
            // kifejezésben szerepel 
            //string sor = Console.ReadLine();
            //string sor2 = Console.WriteLine("Almafa"); eljárásnál erre nincs lehetőség 
            //Console.ReadLine(); // ettől függvényhívás, csak eltekintek a visszatérési érték fogadásától 

            // példa eljárásra: csak meghívom, önállóan, nincs visszatérési érték, így nem 
            // szerepelhet kifejezésben, és nem írhatom értékadó utasítás jobb oldalára 
            // Console.WriteLine("Ez egy eljárás");

            Console.Write("Az a tömb elemeinek kiírása: ");
            // ki kellene jelölni, hogy az a tömbről beszélek (aktuális paraméterélista: a konkrét hívás során a form. paraméterlistára illesztett értékek listája)
            TombKiir(a); // leírom az alprogram hívást, ilyennkor átadom a vezérlést, és ha végzett, akkor innen folytatom a főprogramot 

            Console.Write("A b tömb elemeinek a kiírása: ");
            // ki kellene jelölni, hogy a b tömbről beszélek (aktuális paraméterélista: a konkrét hívás során a form. paraméterlistára illesztett értékek listája)
            TombKiir(b);

            // függvények definiálása és hívása 
            // függvény: kb. működésben ugyanaz, mint az eljárás, csak a hívás végén kötelesek vagyunk 
            // egy a szignatúrában mehatározott típusú értékkel visszatérni 
            // Határozzuk meg a és b tömb elemeinek az összegét külön-külön! 
            Console.WriteLine("Az a tömb elemeinek az összege: {0}",osszeg(a)); // a fgv hívás egy kifejezésben szerepel 
            //osszeg(a);

            long bOsszeg = osszeg(b); // a fgv visszatérési értékét eltárolom egy változóban 
            Console.Write("A b tömb elemeinek az összege: {0}", bOsszeg);
            

            int[] c = new int[0];
            Console.Write("A c tömb elemeinek az összege: {0}", osszeg(c));
            osszeg(c);

            double cAtlag = atlag(c);
            if (cAtlag == double.MaxValue) Console.WriteLine("c tömb átlaga nem számítható ki");
            else Console.WriteLine("A c tömb átlaga: {0}", cAtlag);

            double aAtlag = atlag(a);
            if (aAtlag == double.MaxValue) Console.WriteLine("a tömb átlaga nem számítható ki");
            else Console.WriteLine("Az a tömb átlaga: {0}", aAtlag);


            Console.ReadKey();
        }

        static double atlag(int[] t)
        {
            if (t.Length == 0) return double.MaxValue;

            // osszeg / db szám
            return (double)osszeg(t) / t.Length;
        }

        // feladat, hogy a t tömb elemeinek összegét meghatározzuk, ha tömb üres, akkor ez legyen -1 
        // az osszeg feladata az összeg mehatározása és VISSZAADÁSA, majd a hívó fél eldönti, hogy mit 
        // kezd vele => az összeg egy olyan függvény lesz, amely visszaadja a tömbelemeinek az összegét 
        // fgv. szignatúra: static <visszatérési típus> <név>(<form. paraméterlista)
        // törzs: közvetlenül a szignatúra után kapcsos zárójelpárok között 
        // DE! bármilyen körülmény esetén vissza kell adni egy long típusú értéket, ehhez a return kulcsszót kell használni 
        static long osszeg(int[] t)
        {
            if (t.Length == 0) return -1; // visszaadom a hívás helyére a -1-et és ezzel be is fejezem a végrehajátást
           
            long osszeg = 0;
            for (int i = 0; i < t.Length; i++)
                osszeg += t[i];

            return osszeg;
        }
   
        // main-el egy szinten hozzuk létre az alprogramokat 
        // 1) eljárás létrehozása: nincs visszatérési értéke, így void típussal tér vissza
        // szignatúra: static <visszatérési típus> <név>(<formális paraméterlista>)
        // törzs: a szignatúra után közvetlenül kapcsos zárójelpárok között 

        // a TombKiir eljárásnak meg kell kapnia, hogy konkrétan melyik tömböt kell kiírni 
        // => az alprogram elvárja, hogy "megnevezzük" a kiírni kívánt tömböt, anélkül nem akar dolgozni
        // az alprogram formális paraméter listában írja elő a külvilág számára a meghíváshoz szükséges
        // átadandó adatokat 
        // form. paraméterlista: mintha változó deklarációk lennének, több paraméter esetén ,-vel elválasztva
        // int[] tomb: bemenő paraméter, mindenképpen értéket kell kapnia a hívás során 
        static void TombKiir(int[] tomb) // fejléc: void = eljárás, név=TombKiir, (int[] tomb) = egy int[] típusú paraméterrel hívható ez eljárás, amire tomb néven hivatkozok az eljáráson belül 
        {
            // törzs: ami tartalmazza az algoritmust 
            Console.Write("Tömb elemei: ");
            for (int i = 0; i < tomb.Length - 1; i++)
                Console.Write("{0}, ", tomb[i]);
            Console.WriteLine("{0}", tomb[tomb.Length - 1]);
        }
    }
}
