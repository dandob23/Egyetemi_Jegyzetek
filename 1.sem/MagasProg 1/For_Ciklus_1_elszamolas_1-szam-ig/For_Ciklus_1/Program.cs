using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Ciklus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot:");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szam; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
