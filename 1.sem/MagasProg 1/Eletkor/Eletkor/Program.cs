using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletkor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg, hogy mikor születtél:");
            Console.WriteLine("Év:");
            int ev = int.Parse(Console.ReadLine());
            Console.WriteLine("Hónap:");
            int honap = int.Parse(Console.ReadLine());
            Console.WriteLine("Nap:");
            int nap = int.Parse(Console.ReadLine());
            int eletkor = 2016 - ev;
            if (honap > 9) eletkor = eletkor - 1;
            if (honap == 9 && nap > 18) eletkor--;
            Console.WriteLine("Életkor: {0}év", eletkor);
            Console.ReadKey();
        }
    }
}
