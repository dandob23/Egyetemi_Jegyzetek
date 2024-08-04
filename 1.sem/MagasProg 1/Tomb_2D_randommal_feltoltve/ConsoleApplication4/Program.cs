using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketdimenzios_tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] t = new int[5, 5];
            Random r = new Random();
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    t[x, y] = r.Next(10, 100);
                }
            }
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write("{0} ", t[x,y]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
