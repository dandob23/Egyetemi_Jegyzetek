using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace N20161207
{
    class Program
    {
        static void Feltolt(int[,] tomb, int min, int max)
        {
            Random r = new Random();
            for (int s = 0; s < tomb.GetLength(0); s++)
                for (int o = 0; o < tomb.GetLength(1); o++)
                    tomb[s, o] = r.Next(min, max);
        }
        static void Kiir(int[,] tomb)
        {
            Console.WriteLine();
            for (int s = 0; s < tomb.GetLength(0); s++)
            {
                for (int o = 0; o < tomb.GetLength(1); o++)
                    Console.Write("{0} ", tomb[s, o]);
                Console.WriteLine();
            }
        }
        static void MinMaxKeres(int[,] tomb, out int min, out int max)
        {
            min = tomb[0, 0];
            max = tomb[0, 0];
            for (int s = 0; s < tomb.GetLength(0); s++)
                for (int o = 0; o < tomb.GetLength(1); o++)
                {
                    if (min > tomb[s, o])
                        min = tomb[s, o];
                    if (max < tomb[s, o])
                        max = tomb[s, o];
                }
        }
        static void TombToLista(int[,] tomb, List<int> lista)
        {
            lista.Clear();
            for (int x = 0; x < tomb.GetLength(0); x++)
                for (int y = 0; y < tomb.GetLength(1); y++)
                    lista.Add(tomb[x, y]);
        }
        static void ListaToTombReverse(int[,] tomb, List<int> lista)
        {
            int p = lista.Count - 1;
            for (int x = 0; x < tomb.GetLength(0); x++)
                for (int y = 0; y < tomb.GetLength(1); y++)
                {
                    tomb[x, y] = lista[p];
                    p--;
                }
        }
        static void OszlopCsere(int[,] tomb, int oszlop1, int oszlop2)
        {
            for (int x = 0; x < tomb.GetLength(0); x++)
            {
                int csere = tomb[x, oszlop1];
                tomb[x, oszlop1] = tomb[x, oszlop2];
                tomb[x, oszlop2] = csere;
            }
        }
        static int Parosak(int[,] t, int sor)
        {
            int db = 0;
            for (int x = 0; x < t.GetLength(1); x++)
            {
                if (t[sor, x] % 2 == 0)
                    db++;
            }
            return db;
        }
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            int[,] t = new int[3, 8];
            Feltolt(t, 10, 100);
            Kiir(t);
            int min;
            int max;
            MinMaxKeres(t, out min, out max);
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            TombToLista(t, lista);
            ListaToTombReverse(t, lista);
            Kiir(t);
            OszlopCsere(t, 0, 7);
            Kiir(t);
            Console.WriteLine();
            int osszes = 0;
            for (int i = 0; i < t.GetLength(0); i++)
            {
                Console.WriteLine("{0}. sorban {1} db páros", i + 1, Parosak(t, i));
                osszes += Parosak(t, i);
            }
            Console.WriteLine("Összesen {0} db páros", osszes);
            Console.ReadKey();
        }
    }
}