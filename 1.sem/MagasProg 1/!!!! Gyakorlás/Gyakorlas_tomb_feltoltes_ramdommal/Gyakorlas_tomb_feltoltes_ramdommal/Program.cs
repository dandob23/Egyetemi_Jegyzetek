using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_tomb_feltoltes_ramdommal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] szamok = new int[10];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(10, 100);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            Console.ReadKey();
        }
    }
}
