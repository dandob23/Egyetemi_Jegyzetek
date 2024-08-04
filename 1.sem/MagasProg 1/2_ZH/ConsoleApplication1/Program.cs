using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Feltölteni a 2D tömböt
        static void Feltolt(int[,] tomb)
        {
            Random r = new Random();
            for (int s = 0; s < tomb.GetLength(0); s++)
            for (int o = 0; o < tomb.GetLength(1); o++)
            tomb[s, o] = r.Next(10,100);
        }
        //Kiírni a 2D tömböt
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
        //Minimum érték az egész tömbre
        static void Minimum(int[,] tomb, out int min)
        {
            min = tomb[0, 0];           
            for (int s = 0; s < tomb.GetLength(0); s++)
            for (int o = 0; o < tomb.GetLength(1); o++)
                {
                    if (min > tomb[s, o])
                        min = tomb[s, o];                    
                }
        }
        //Bekérni a 3db számot
        static void Bekero()
        {
            int[] tomb2 = new int[3];

            int i = 0;
            while (i < tomb2.Length)
            {
                Console.WriteLine("Add meg a {0}. számot!", i);
                int x = int.Parse(Console.ReadLine());

                if (x < 10 || x > 100)
                {
                    Console.WriteLine("Nem megfelelő érték!");
                    continue;
                }
                tomb2[i] = x;
                i++;
            }            
        }
        //Main
        static void Main(string[] args)
        {
            int[,] t = new int[5, 10];
            Feltolt(t);            
            Kiir(t);
            int min = 0;
            Minimum(t, out min);
            Console.WriteLine("Minimum = {0}", min);
            Bekero();
            Console.ReadKey();
        }

    }
}
