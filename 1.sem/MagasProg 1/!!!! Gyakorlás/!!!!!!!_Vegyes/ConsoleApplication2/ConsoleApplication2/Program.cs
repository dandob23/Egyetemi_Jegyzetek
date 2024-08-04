using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_Feltoltes_Kezzel_While_Muveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[5];

            int i = 0;
            while (i < tomb.Length)
            {
                Console.WriteLine("Add meg a {0}. számot!", i);
                int x = int.Parse(Console.ReadLine());

                if (x < 0 || x > 100)
                {
                    Console.WriteLine("Nem megfelelő érték!");               
                    continue;
                }
                tomb[i] = x;
                i++;
            }
            Console.WriteLine("Értékek:");
            for (int j = 0; j < tomb.Length; j++)
            {
                Console.WriteLine(tomb[j]);                
            }
            //osszeg
            Console.WriteLine("Szumma:");
            int sum = 0;
            for (int k = 0; k < tomb.Length; k++)
            {
                sum = sum + tomb[k];
            }
            Console.WriteLine(sum);
            //darab
            Console.WriteLine("Darab:");
            int db = 0;
            for (int m = 0; m < tomb.Length; m++)
            {
                db++;
            }
            Console.WriteLine(db);
            //átlag            
            Console.WriteLine("Átlag:");
            int atl;
            atl = sum / db;            
            Console.WriteLine(atl);            
            Console.ReadKey();            
        }
    }
}
