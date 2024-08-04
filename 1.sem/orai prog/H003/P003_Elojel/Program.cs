using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P003_Elojel
{
    class Program
    {
        // véletlenszám generálás 1) random osztály példányosítás 
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // generáljunk 1000 db véletlen számot a [-100;100] intervallumon 
            // és írjuk ki, hogy a generált számok hány százaléka volt negatív/0/pozitív

            // vél. szám generálás. használható 
            // rnd.Next(): ilyenkor [0;int max érték[
            // rnd.Next(int max): ilyenkor [0; max[
            // rnd.Next(int min, int max): ilyenkor [min;max[

            int i = 0; // ezzel számolom, hogy hányszor futott le a ciklus
            int negativDb = 0;
            int nullaDb = 0;
            int pozitivDb = 0;
            while(i < 1000)
            {
                // generálok egy számot 
                int szam = rnd.Next(-100, 101); // [-100;100] intervallumról kell 

                // megvizsgálom a szám előjelét és megszámolom az előfordulást 
                if(szam < 0) 
                {
                    negativDb++;
                }
                else if(szam == 0)
                {
                    nullaDb++;
                }
                else
                {
                    pozitivDb++;
                }
                
                i++; // minden ciklusmag lefutás végén növelem eggyel a változót 
            }

            Console.WriteLine("A generált számok között {0} db negatív, {1} db nulla és {2} db pozitív van", negativDb, nullaDb, pozitivDb);
            Console.ReadKey();






        }
    }
}
