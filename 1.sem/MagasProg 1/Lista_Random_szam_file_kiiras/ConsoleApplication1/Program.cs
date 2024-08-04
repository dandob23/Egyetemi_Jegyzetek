using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> lista = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(r.Next(10, 100));
            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0} ", lista[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                sum = sum + lista[i];
            }
            int paratlan = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 != 0)
                {
                    paratlan++;
                }
            }
            Console.WriteLine("Összeg: {0}", sum);
            Console.WriteLine();
            Console.WriteLine("{0} db páratlan szám volt", paratlan);
            //törlés
            int c = lista.Count;
            for (int i = 0; i < c; i++)
            {
                if (lista[c - 1 - i] % 2 != 0)
                {
                    lista.RemoveAt(c - 1 - i);
                }
            }
            //kiiratás
            Console.WriteLine();
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0} ", lista[i]);
            }
            //kiiratás fileba
            StreamWriter sw = new StreamWriter("paros.txt");
            for (int i = 0; i < lista.Count; i++)
            {
                sw.WriteLine(lista[i]);
            }
            sw.Close();
            Console.ReadKey();
        }
    }
}
