using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] t = new int[100];
            for (int i = 0; i < 10000; i++)
            {
                int n = r.Next(10, 100);
                t[n]++;
            }
            for (int i = 0; i < 100; i++)
            {
                if (t[i] > 0)
                {
                    Console.WriteLine("{0}. {1} db", i, t[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
