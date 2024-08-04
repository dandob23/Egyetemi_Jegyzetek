using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int c = 1; c <= 1000; c++)
            {
                if ((c % 3 == 0) && (c % 27 == 0) && (c % 2 != 0))
                    count++;
            }

            int[] tomb = new int[count];
            int i = 0;
            int n = 1;
            while (i < tomb.Length)
            {
                if ((n % 3 == 0) && (n % 27 == 0) && (n % 2 != 0))
                {
                    tomb[i] = n;
                    i++;
                }
                n++;
            }
            for (int c = 0; c < tomb.Length; c++)
            {
                Console.WriteLine("{0,3} ", tomb[c]);
            }
            Console.ReadKey();
        }
    }
}
