using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NFaktElsoLehetoseg();
            NFaktMasodikLehetoseg();
            //NFaktHarmadikLehetoseg(1,6);
            OsszElsoLehetoseg();
            OsszMasodikLehetoseg();
            OsszHarmadikLehetoseg();
            Console.ReadLine();
        }

        #region N MEGHATÁROZÁSA LEHETŐSÉGEK

        //első
        public static int NFaktElsoLehetoseg()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\tElső lehetőség\n");
            Console.Write("\tAdja meg az n-et: ");
            int n = int.Parse(Console.ReadLine());
            int s = 1;
            if (n < 0)
            {
                Console.WriteLine("\tCsak pozitív szám lehet az n!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    s *= i;
                }

                Console.WriteLine($"\t{n}! = {s}");
            }
            return s;
        }

        //második
        public static int NFaktMasodikLehetoseg()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\tMásodik lehetőség\n");
            Console.Write("\tAdja meg az n-et: ");
            int n = int.Parse(Console.ReadLine());
            int result = Faktorialis(n);

            if (n < 0)
            {
                Console.WriteLine("\tCsak pozitív szám lehet az n!");
            }
            else
            {

                Console.WriteLine($"\t{n}! = {result}");
                Console.WriteLine("-----------------------------------------");
            }
            return result;
        }
        public static int Faktorialis(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Faktorialis(n - 1);
            }
        }

        //harmadik
        public static int NFaktHarmadikLehetoseg(int n, int m)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\tHarmadik lehetőség\n");

            int result = Fakt(n, m);
            int s;
            int k;
            if (n == m)
            {
                s = n;
            }
            else
            {
                k = (n + m) / 2;
                s = Fakt(n, k) * Fakt(k + 1, m);
            }
            Console.WriteLine($"\t{n}! = {result}");
            return s;
        }
        public static int Fakt(int n, int m)
        {
            if (n == m)
            {
                return n;
            }
            else
            {
                int k = (n + m) / 2;
                return Fakt(n, k) * Fakt(k + 1, m);
            }
        }
        #endregion


        #region ÖSSZEGZÉS LEHETŐSÉGEK

        //első
        public static int OsszElsoLehetoseg()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\tElső lehetőség\n");
            Console.Write("\tAdja meg az n-et: ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            if (n < 0)
            {
                Console.WriteLine("\tCsak pozitív szám lehet az n!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    s += i;
                }

                Console.WriteLine($"\tSzámok összegezve = {s}");
            }
            return s;
        }

        //második
        public static int OsszMasodikLehetoseg()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\tMásodik lehetőség\n");
            Console.Write("\tAdja meg az n-et: ");
            int n = int.Parse(Console.ReadLine());
            int result = Osszegzes(n);

            if (n < 0)
            {
                Console.WriteLine("\tCsak pozitív szám lehet az n!");
            }
            else
            {

                Console.WriteLine($"\tSzámok összegezve = {result}");
                Console.WriteLine("-----------------------------------------");
            }
            return result;
        }

        public static int Osszegzes(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + Osszegzes(n - 1);
            }
        }

        //harmadik
        public static int OsszHarmadikLehetoseg()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\tHarmadik lehetőség\n");
            Console.Write("\tAdja meg az n-et: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("\tAdja meg az m-et: ");
            int m = int.Parse(Console.ReadLine());

            int s = 0;
            if (n < 0)
            {
                Console.WriteLine("\tCsak pozitív szám lehet az n!");
            }
            else
            {
                for (int i = m; i <= n; i++)
                {
                    s += i;
                }

                Console.WriteLine($"\tSzámok összegezve = {s}");
            }
            return s;
        }
        #endregion
    }
}
