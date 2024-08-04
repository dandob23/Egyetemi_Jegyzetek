using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_3_Husz_tomb_feltoltve_osszegezve
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] t = new int[20];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(10, 100);
            }
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();
            int szum = 0;
            for (int i = 0; i < t.Length; i++)
            {
                szum = szum + t[i];
            }
            Console.Write("Szum: {0}", szum);
            Console.ReadKey();
        }
    }
}
