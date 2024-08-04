using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_alap
{
    class Program
    {
        static void Info()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Üdvözöllek a programomban, kurva jó, mi?");
            Console.WriteLine("****************************************");
        }

        static int Bevitel()
        {
            Console.WriteLine("Adj meg egy számot:");
            int z = int.Parse(Console.ReadLine());
            return z;
        }
        static void Main(string[] args)
        {
            Info();
            int x = Bevitel();
            int y = Bevitel();
            Console.WriteLine("Most kiírom a bevitt értékeket:");
            Console.WriteLine(x);
            Console.WriteLine(y);










            Console.ReadKey();
        }
    }
}
