using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Ciklus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mettől:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Meddig:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = a; i <= b; i++)
            {
                if ((i % 3 == 0) && (i % 2 != 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
