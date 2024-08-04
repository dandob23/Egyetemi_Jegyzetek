using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beugro_5
{
    class Program
    {
        //2 megkapott szám alapján vizsgálja a tömb elemeit hogy az első szám osztója a második pedig ne legyen osztója és ezt listában adja vissza

        static List<int> listaki = new List<int>();

        static List<int> Beugro5(int[] tomb, int szam1, int szam2)
        {
            for (int i = 0; i < tomb.Length; i++)
                if ((tomb[i] % szam1 == 0) && (tomb[i] % szam2 != 0))

                    listaki.Add(tomb[i]);

            return listaki;
        }
        static void Main(string[] args)
        {
            int[] tomb = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int szam1 = 2;
            int szam2 = 3;
            Beugro5(tomb, szam1, szam2);

            for (int i = 0; i < listaki.Count; i++)
                Console.Write("{0},", listaki[i]);

            Console.ReadKey();
        }
    }
}
