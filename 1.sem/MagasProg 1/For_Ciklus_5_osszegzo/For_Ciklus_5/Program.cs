using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Ciklus_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int szum = 0;
            for (int szam = 1; szam <=20; szam++)
            {
                szum = szum + szam;
            }
            Console.WriteLine(szum);
            Console.ReadKey();
        }
    }
}
