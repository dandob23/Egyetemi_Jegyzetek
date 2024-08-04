using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beugro_2
{
    class Program
    {
        //Két tömb közös elemeit listázza ki

        static List<int> lista = new List<int>();

        static List<int> Beugro3(int[] tomb1, int[] tomb2)
        {
            for (int i = 0; i < tomb1.Length; i++)
                for (int j = 0; j < tomb2.Length; j++)
                    if (tomb1[i] == tomb2[j])

            lista.Add(tomb1[i]);
            return lista;
        }
        static void Main(string[] args)
        {
            int[] tomb1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] tomb2 = new int[5] { 3, 4, 5, 6, 1 };
            Beugro3(tomb1, tomb2);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0},", lista[i]);
            }
            Console.ReadKey();



        }
    }
}
