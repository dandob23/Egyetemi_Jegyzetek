using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eletkor_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg, hogy mikor születtél:");
            Console.WriteLine("\nÉv:");
            int ev = int.Parse(Console.ReadLine());
            Console.WriteLine("Hónap:");
            int honap = int.Parse(Console.ReadLine());
            Console.WriteLine("Nap:");
            int nap = int.Parse(Console.ReadLine());
            int eletkor = DateTime.Now.Year - ev;
            if (honap > DateTime.Now.Month) eletkor = eletkor - 1;
            if (honap == DateTime.Now.Month && nap > DateTime.Now.Day) eletkor--;
            Console.WriteLine("Életkor: {0}év", eletkor);
            Console.ReadKey();
        }
    }
}
