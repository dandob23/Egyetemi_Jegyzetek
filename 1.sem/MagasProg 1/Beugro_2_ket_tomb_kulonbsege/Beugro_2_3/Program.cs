using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beugro_2
{
    class Program
    {
        //Nekem kellett egy függvényt ami paraméterként bekér két tömböt és listában visszaadja azokat az elemeket amelyek csak az egyik tömbben szerepelnek.

        static List<int> lista = new List<int>();

        static List<int> Beugro2(int[] tomb1, int[] tomb2)
        {
            //1. tömb elemei egyéniek-e
            for (int i = 0; i < tomb1.Length; i++)
            {
                bool nincs = true;
                for (int j = 0; j < tomb2.Length; j++)
                    if (tomb1[i] == tomb2[j])
                        nincs = false;
                if (nincs)
                    lista.Add(tomb1[i]);
            }
            //2. tömb elemei egyéniek-e
            for (int i = 0; i < tomb2.Length; i++)
            {
                bool nincs = true;
                for (int j = 0; j < tomb1.Length; j++)
                    if (tomb2[i] == tomb1[j])
                        nincs = false;
                if (nincs)
                    lista.Add(tomb2[i]);
            }
            return lista;
        }    
        static void Main(string[] args)
        {
            int[] tomb1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] tomb2 = new int[5] { 3, 4, 5, 6, 1 };
            Beugro2(tomb1, tomb2);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0},", lista[i]);
            }
            Console.ReadKey();



        }
    }
}
