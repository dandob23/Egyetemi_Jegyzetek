using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1123
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ElsoFeladat();
            MasodikFeladat();
            HarmadikFeladat();        
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();
            HetedikFeladat();
            NyolcadikFeladat();
            Console.ReadLine();
        }

        static void ELVALASZTO()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=====================================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #region FELADATOK
        static void ElsoFeladat()
        {
            ELVALASZTO();


            Console.WriteLine("1. Feladat");

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(3);
            list.AddLast(33);
            list.AddLast(3333);
            list.AddLast(333);

            Console.WriteLine("A kapott lista:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            list.Remove(3333);

            Console.WriteLine("Eltávolítás után");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            ELVALASZTO();
        }
        static void MasodikFeladat()
        {
            ELVALASZTO();
            Console.WriteLine("2. Feladat");
            int[] tomb = new int[8];
            tomb[0] = 3;
            tomb[1] = 33;
            tomb[2] = 3333;
            tomb[3] = 333;

            LinkedList<int> list = new LinkedList<int>(tomb);
            

            Console.WriteLine("A kapott lista:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            list.Remove(3333);

            Console.WriteLine("Eltávolítás után");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            ELVALASZTO();

        }
        static void HarmadikFeladat()
        {
            ELVALASZTO();
            Console.WriteLine("3. Feladat");
            Console.WriteLine("A folyamat: 9, 8, 7, 6, Törlés, 5, Törlés, 4");

            Stack<int> verem = new Stack<int>();
            verem.Push(9);
            verem.Push(8);
            verem.Push(7);
            verem.Push(6);
            verem.Pop();
            verem.Push(5);
            verem.Pop();
            verem.Push(4);
            
            Console.WriteLine("A kapott verem:");
            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }


            ELVALASZTO();


        }
        static void NegyedikFeladat()
        {
            ELVALASZTO();
            Console.WriteLine("4. Feladat");

            Console.WriteLine("A folyamat: 9, 8, 7, 6, Törlés, 5, Törlés, 4");

            int[] tomb = new int[6];
            
            Stack<int> verem = new Stack<int>(tomb);

            tomb[0] = 9;
            tomb[1] = 8;
            tomb[2] = 7;
            tomb[3] = 6;

            verem.Push(tomb[0]);
            verem.Push(tomb[1]);
            verem.Push(tomb[2]);
            verem.Push(tomb[3]);
            verem.Pop();
            tomb[4] = 5;
            verem.Push(tomb[4]);
            verem.Pop();
            tomb[5] = 4;
            verem.Push(tomb[5]);

            Console.WriteLine("A kapott verem:");
            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }

            ELVALASZTO();

        }

        static void OtodikFeladat()
        {
            ELVALASZTO();

            Console.WriteLine("5. Feladat");
            Console.WriteLine("A folyamat: 9, 8, 7, 6, Törlés, 5, Törlés, 4");
            
            List<int> lista = new List<int>();
            lista.Add(9);
            lista.Add(8);
            lista.Add(7);
            lista.Add(6);

            Queue<int> sor = new Queue<int>(lista);


            sor.Dequeue();
            lista.Add(5);
            sor.Enqueue(lista[4]);
            sor.Dequeue();
            lista.Add(4);
            sor.Enqueue(lista[5]);

            Console.WriteLine("A kapott sor:");
            foreach (var item in sor)
            {
                Console.WriteLine(item);
            }
            ELVALASZTO();
        }

        static void HatodikFeladat()
        {
            ELVALASZTO();

            Console.WriteLine("6. Feladat");
            Console.WriteLine("A folyamat: 9, 8, 7, 6, Törlés, 5, Törlés, 4");
            int[] tomb = new int[6];
            Queue<int> sor = new Queue<int>(tomb);

            tomb[0] = 9;
            tomb[1] = 8;
            tomb[2] = 7;
            tomb[3] = 6;

            sor.Enqueue(tomb[0]);
            sor.Enqueue(tomb[1]);
            sor.Enqueue(tomb[2]);
            sor.Enqueue(tomb[3]);
            sor.Dequeue();
            tomb[4] = 5;
            sor.Enqueue(tomb[4]);
            sor.Dequeue();
            tomb[5] = 4;
            sor.Enqueue(tomb[5]);

            Console.WriteLine("A kapott sor:");
            foreach (var item in sor)
            {
                Console.WriteLine(item);
            }
            ELVALASZTO();            
        }

        static void HetedikFeladat()
        {
            ELVALASZTO();

            Console.WriteLine("7. Feladat");
            Console.WriteLine("A folyamat: 9, 8, 7, 6, Törlés, 5, Törlés, 4");
            List<int> lista = new List<int>();
            lista.Add(9);
            lista.Add(8);
            lista.Add(7);
            lista.Add(6);

            Stack<int> verem = new Stack<int>(lista);

            verem.Pop();
            lista.Add(5);
            verem.Push(lista[4]);
            verem.Pop();
            lista.Add(4);
            verem.Push(lista[5]);

            Console.WriteLine("A kapott verem:");
            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }
            ELVALASZTO();
        }

        static void NyolcadikFeladat()
        {
            ELVALASZTO();

            Console.WriteLine("8. Feladat");
            Console.WriteLine("A folyamat: 9, 8, 7, 6, Törlés, 5, Törlés, 4");
            int[] tomb = new int[6];
            Stack<int> verem = new Stack<int>(tomb);

            tomb[0] = 9;
            tomb[1] = 8;
            tomb[2] = 7;
            tomb[3] = 6;

            verem.Push(tomb[0]);
            verem.Push(tomb[1]);
            verem.Push(tomb[2]);
            verem.Push(tomb[3]);
            verem.Pop();
            tomb[4] = 5;
            verem.Push(tomb[4]);
            verem.Pop();
            tomb[5] = 4;
            verem.Push(tomb[5]);

            Console.WriteLine("A kapott verem:");
            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }
            ELVALASZTO();
        }
        #endregion
    }
}
