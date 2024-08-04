using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElsoFeladat();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            MasodikFeladat();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            HarmadikFeladat();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            NegyedikFeladat();

            Console.ReadKey();
        }

        static void ElsoFeladat()
        {
            #region Feladat
            /*
             Készítsen egy láncolt listát a 1, 11, 1111, 111 kulcsokból. Az üres listából indulva az elemeket
            egyenként szúrja be a lista elejére. Irassa ki a kapott listát! Majd törölje a 1111-et, és szúrja be a lista
            végére a 2222-t. Írassa ki az így kapott listát is!
          */
            #endregion

            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(11);
            list.AddFirst(1111);
            list.AddFirst(111);

            Console.WriteLine("Eredeti lista: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            list.Remove(1111);
            list.AddLast(2222);

            Console.WriteLine("Módosított lista: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void MasodikFeladat()
        {
            #region Feladat
            /*
             Feladat: Készítse el ugyanezt a láncolt listát egy tömbbel! Ehhez legyen adott (tárolási célra) egy
            nyolcelemű tömb.

            fej = 4

            kulcs: 0.0 = -1; 0.1 = 111; 0.2 = -1; 0.3 = 11; 0.4 = 1111; 0.5 = -1; 0.6 = -1; 0.7 = 1
            következő: 1.0 = -1; 1.1 = 7; 1.2 = -1; 1.3 = -1; 1.4 = 1; 1.5 = -1; 1.6 = -1; 1.7 = 3

            Irassa ki a kapott listát! Majd törölje a 1111-et, és szúrja be a lista végére a 2222-t! Írassa ki az így
            kapott listát is!
             */
            #endregion
            int fej = 4;
            int[] kulcs= {-1, 111, -1, 11, 1111, -1, -1, 1 };
            int[] kovetkezo = {-1, 7, -1, -1, 1, -1, -1, 3 };


            LinkedList<int> list = new LinkedList<int>(kulcs);
            LinkedList<int> list2 = new LinkedList<int>(kovetkezo);
            Console.WriteLine("Eredeti lista: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.Remove(1111);
            list.AddLast(2222);

            Console.WriteLine("Módosított lista: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void HarmadikFeladat()
        {
            #region Feladat
            /*
             Feladat: Implementálja egy verem működését egy 8 elemű tömbbel. Végezzük el a megadott sorrendben
            a felsorolt kulcsokkal a műveleteket. (Ha a felsorolásban egy T betűt talál, akkor a ”megfelelő”
            elemet törölni kell, egyébként pedig betesszük az elemet a veremként működő tömbünkbe.) A kulcsok
            felsorolása: 9, 8, 7, 6, T, 5, T, 4.
             
             */
            #endregion

            int[] tomb = new int[8];

            tomb[0] = 9;
            tomb[1] = 8;
            tomb[2] = 7;
            tomb[3] = 6;

            Stack<int> verem = new Stack<int>(tomb);
            
            verem.Pop();
            tomb[4]= 5;
            verem.Push(tomb[4]);
            verem.Pop();
            tomb[5] = 4;
            verem.Push(tomb[5]);


            Console.WriteLine("A kapott verem: ");
            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }


        }

        static void NegyedikFeladat()
        {
            #region Feladat
            /*
             Feladat: Készítenünk kell egy sort. Végezzük el a megadott sorrendben a felsorolt kulcsokkal a
            műveleteket. (Ha a felsorolásban egy T betűt talál, akkor a ”megfelelő” elemet törölni kell) A kulcsok
            felsorolása: 9, 8, 7, 6, T, 5, T, 4.
             */
            #endregion

            Queue<int> sor = new Queue<int>();
            sor.Enqueue(9);
            sor.Enqueue(8);
            sor.Enqueue(7);
            sor.Enqueue(6);
            sor.Dequeue();
            sor.Enqueue(5);
            sor.Dequeue();
            sor.Enqueue(4);

            Console.WriteLine("A kapott sor: ");
            foreach (var item in sor)
            {
                Console.WriteLine(item);
            }
        }
    }
}
