using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002_Lotto
{
    class Program
    {
        // static, mivel közvetlenül a Programon belül hoztam létre
        // bármelyik alprogram hozzáfér, amelyik a Programon belül van 
        static Random rnd = new Random(); 
        static void Main(string[] args)
        {
            /*
              Generáljuk 5 véletlen számot az [1;90] intervallumról 
              ismétlődés nélkül (ötös lottó). Kérjünk be ugyanígy 5 
              számot a konzolról és írjuk ki, hogy hány találatos 
              a szelvényünk. 
             */

            // 1 5 db szám, az [1;90] intervallumról ismétlődés nélkül
            int[] nyeroszamok = generalSzamok(5, 1, 90);
            Console.Write("Nyerőszámok: ");
            TombKiir(nyeroszamok);

            // kérjünk be 5 db számot ismétlődés nélkül az [1;90] intervallumról a billentyűzetről 
            Console.WriteLine("A következőkben kérem, hogy adjon meg 5 db számot egymás után az [1;90] intervallumról ismétlődés nélkül!");
            int[] tipp = szamokBeker(5, 1, 90);
            Console.Write("Tippek: ");
            TombKiir(tipp);

            // írjuk ki a találatok számát, illetve, hogy mely számokat találtuk el 
            int talalatokSzama = kozosElemekDb(nyeroszamok, tipp);
            Console.WriteLine("Találatok száma: {0}", talalatokSzama);
            int[] talalatok = kozosElemek(nyeroszamok, tipp);
            Console.Write("Az eltalált számok: ");
            TombKiir(talalatok);

            Console.ReadKey();
        }

        static int[] kozosElemek(int[] a, int [] b)
        {
            int[] kozosElemek = new int[kozosElemekDb(a, b)];
            int i = 0; // mutatja, hogy éppen hová kell a következő elemet rakni a kozosElemekben
            for(int j = 0; j < a.Length; j++)
                if(benneVanE(b, 0, b.Length - 1, a[j]))
                {
                    kozosElemek[i] = a[j];
                    i++;
                }

            return kozosElemek;
        }

        static int kozosElemekDb(int[] a, int[] b)
        {
            int db = 0;
            for (int i = 0; i < a.Length; i++)
                if (benneVanE(b, 0, b.Length - 1, a[i])) db++;
            return db;
        }

        static int[] szamokBeker(int db, int min, int max)
        {
            int[] szamok = new int[db];
            int i = 0; // éppen hanyadik elemet akarom beállítani 
            int ertek; // ebben tárolom el az éppen beolvasott értéket 
            do
            {
                Console.Write("Kérem a {0}. értéket: ", i + 1);
                if(int.TryParse(Console.ReadLine(), out ertek) && 
                   min <= ertek && ertek <= max && 
                   !benneVanE(szamok, 0, i-1, ertek))
                {
                    szamok[i] = ertek;
                    i++;
                }
            }
            while (i < szamok.Length);

            return szamok;
        }

        static void TombKiir(int[] t)
        {
            for (int i = 0; i < t.Length - 1; i++)
                Console.Write("{0}, ", t[i]);
            Console.WriteLine("{0}", t[t.Length - 1]);
        }

        // a paraméterek miatt, általános lesz a függvény 
        static int[] generalSzamok(int db, int min, int max)
        {
            /*int db = 5;
            int min = 1;
            int max = 90;*/

            int[] szamok = new int[db]; // db mennyiségű helyet foglalok le 
            int i = 0; // i-vel mutatok arra a helyre, amelyet éppen be szeretnék állítani
            while(i < szamok.Length) // a szamok tömb minden elemét be kell állítani, csak akkor végzek
            {
                int kovetkezoSzam = rnd.Next(min, max + 1); // generálok egy vél. számot
                // le kell ellenőriznem, hogy 0-tól i-1-ig előfordul-e a szám --> igen/nem (bool)
                if(!benneVanE(szamok, 0, i-1, kovetkezoSzam))
                {
                    szamok[i] = kovetkezoSzam;
                    i++;
                }

            }

            return szamok;
        }

        // t: miben? indextol: honnan nezem?, indexig: meddig nézem?, szam: mit keresek? 
        static bool benneVanE(int[] t, int indextol, int indexig, int szam)
        {
            for (int i = indextol; i <= indexig; i++)
                if (t[i] == szam) return true;

            return false;
        }

    }
}
