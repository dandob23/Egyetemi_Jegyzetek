using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            /*
             FELADATOK
            a) egész szám 0 és 100 között
            b) páros egész a -23 és 55 intervallumon
            c) Páratlan egész a 24 és végtelen intervallumon
             */

            //------------------------------------------------------------------------------------------------------------//

            int aFeladat = rnd.Next(0, 100);
            Console.WriteLine("Egész szám random generálása 0 és 100 között\r\n");
            Console.WriteLine("a) feladat: {0}\r\n\r\n\r\n", aFeladat);

            //------------------------------------------------------------------------------------------------------------//

            int bFeladat = 0;
            Console.WriteLine("Páros egész random szám a -23 és 55 intervallumon\r\n");
            do
            {
                bFeladat = rnd.Next(-24, 56);
            } while (bFeladat % 2 != 0);
            Console.WriteLine("b) feladat: {0}\r\n\r\n\r\n", bFeladat);

            //------------------------------------------------------------------------------------------------------------//

            int cFeladat = 0;
            Console.WriteLine("Páratlan egész random szám a 24 és végtelen intervallumon\r\n");
            do
            {
                cFeladat = rnd.Next(25, int.MaxValue);
            } while (cFeladat % 2 == 0);
            Console.WriteLine("c) feladat: {0}", cFeladat);

            //------------------------------------------------------------------------------------------------------------//


            Console.ReadKey();
        }
    }
}
