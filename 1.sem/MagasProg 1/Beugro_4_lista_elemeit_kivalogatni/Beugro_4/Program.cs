using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beugro_4
{
    class Program
    {
        // Írj egy olyan fv-t ami egy szám típusú listát ad vissza, bemenő paraméterei: egy szám típusú lista, és 2 egész típusú szám. 
        // feladat: Válogassuk ki az összes olyan számot a bemenő listából, ami kisebb volt mint az első bemenő szám(paraméter) vagy nagyobb mint a második
        // és az így létrejött új listát adja vissza a fv.

        static List<int> listaki = new List<int>();

        static List<int> Beugro4(List<int> listabe, int szam1, int szam2)
        {            
            for (int i = 0; i < listabe.Count; i++)
                if (listabe[i] < szam1 || listabe[i] > szam2)
                    listaki.Add(listabe[i]);
            return listaki;           
        }


        static void Main(string[] args)
        {
            List<int> listabe = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int szam1 = 4;
            int szam2 = 6;
            Beugro4(listabe, szam1, szam2);

            for (int i = 0; i < listaki.Count; i++)
                Console.Write("{0},", listaki[i]);

            Console.ReadKey();
        }
    }
}
