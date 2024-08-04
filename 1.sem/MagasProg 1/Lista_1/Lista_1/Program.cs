using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            int n = 1;
            while (lista.Count < 10)
            {
                if ((n % 3 == 0) && (n % 27 == 0) && (n % 2 != 0))
                {
                    lista.Add(n);
                }
                n++;
            }
            for (int c = 0; c < lista.Count; c++)
            {
                Console.WriteLine("{0,3} ", lista[c]);
            }
            Console.ReadKey();
        }
    }
}
