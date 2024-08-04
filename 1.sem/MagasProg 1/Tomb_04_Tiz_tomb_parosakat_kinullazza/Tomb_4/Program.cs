using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_4_Tiz_Tomb_Parosakra_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] t = new int[10];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(10, 100);
            }
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (t[i] % 2 == 0)
                {
                    t[i] = 0;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine("{0} ", t[i]);
            }
            Console.WriteLine();
            int szum = 0;
            for (int i = 0; i < t.Length; i++)
            {
                szum = szum + t[i];
            }
            Console.WriteLine("Szum: {0}", szum);
            Console.ReadKey();
        }
    }
}
