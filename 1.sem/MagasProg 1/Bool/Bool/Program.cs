using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            bool c = false;
            if ((a && b) || (a && c) || !(a && b && c))
            {
                Console.WriteLine("Igaz");
            }
            else
            {
                Console.WriteLine("Hamis");
            }
            Console.ReadKey();
        }
    }
}
