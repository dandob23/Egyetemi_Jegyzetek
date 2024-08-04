using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_tomb_feltoltes_kezzel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            
            //bevitel
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Add meg a {0}. elemet:", i+1);
                szamok[i] = int.Parse(Console.ReadLine());
            }
            //kiiratás
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]);
            }




            Console.ReadKey();


        }
    }
}
