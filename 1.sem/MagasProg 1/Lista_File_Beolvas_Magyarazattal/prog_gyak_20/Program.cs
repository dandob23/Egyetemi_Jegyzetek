using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // EZ MINDIG KELL HA FÁJLMŰVELETEKKEL FOGUNK DOLGOZNI

namespace prog_gyak_20
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////// FÁJL OLVASÁS ///////////
            // LISTA BEVEZETÉSE
            // Megadjuk, hogy listát fogunk létrehozni, <int>-el adjuk meg, mert INT típusú adatokkal fogunk dolgozni.
            // A "temp" a lista neve
            List<int> temp = new List<int>();

            // Új fájlolvasót vezetünk be, majd rögtön MEG IS NYITJUK a fájlt.
            StreamReader rfile = File.OpenText("szamok.txt");

            // SORONKÉNTI BEOLVASÁS
            // Beolvassuk a fájl ELSŐ sorát
            string s = rfile.ReadLine();
            // Folytatjuk a beolvasást AMÍG el nem érjük a fájl UTOLSÓ sorát. 
            //   (s!=null)   --> Addig csinálja míg a következő sor ÜRES nem lesz.

            while (s != null)
            {
                // Hozzáadjuk a listához a listához a sorokat (temp.add()), de előbb PARSE-olni kell, hogy ->
                // Számként legyen kezelve, NE pedig STRING-ként.
                temp.Add(int.Parse(s));
                // Betöltjük az "s" változóba a következő sort
                s = rfile.ReadLine();
            }
            
            // Ha végeztünk a fájlműveletekkel LE KELL ZÁRNI a fájlt.
            rfile.Close();

            // LISTA KIÍRÁSA
            // A LISTA 0. elemétől a Lista UTOLSÓ eleméig (temp.count) EGYENKÉNT kiírjuk az eltárolt értékeket
            for (int i = 0; i < temp.Count; i++)
            {
                // A konkrét kiíratás
                Console.Write("{0} ", temp[i]);
            }
            // Tovább várjon egy ENTER gombra, ne álljon le a program futása
            Console.ReadLine();
        }
    }
}
