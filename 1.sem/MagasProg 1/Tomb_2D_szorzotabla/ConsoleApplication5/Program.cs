using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketdimenzios_tomb_szorzotabla
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int mx = 10;
            //int my = 10;
            int[,] t = new int[10, 10];
            //Random r = new Random();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    t[x, y] = (x + 1) * (y + 1);
                }
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write("{0,4} ", t[x, y]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
