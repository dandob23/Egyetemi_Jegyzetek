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
            //tömb feltöltés
            Random rnd = new Random();
            int[] szamok = new int[10];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(10, 100);
            }
            //kiiratás
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }
            //min. érték
            int min = int.MaxValue;
            foreach (int x in szamok)
                if (x < min)
                    min = x;
            if (szamok.Length > 0)
                Console.WriteLine("A legkisebb elem: {0}", min);
            else
                Console.WriteLine("A tömb üres");

            Console.ReadKey();
        }
    }
}
