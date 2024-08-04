using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_2_Tiz_db_tomb_feltoltve_osszegezve
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] t = new int[10];
            for (int i = 0; i < 10; i++)
            {
                t[i] = r.Next(10, 100);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} ", t[i]);
            }
            Console.WriteLine();
            int szum = 0;
            for (int i = 0; i < 10; i++)
            {
                szum = szum + t[i];
            }
            Console.WriteLine("Szum: {0}", szum);
            Console.ReadKey();
        }
    }
}
