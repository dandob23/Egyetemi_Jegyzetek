using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tElső feladat");
            for (int i = 0; i <= 10; i++)
            {
                double a_i = ElsoFeladat(i);
                Console.WriteLine($"a_{i} = {a_i}");
            }
            Console.WriteLine("===========================================================================================\n");




            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tMásodik feladat");
            int masodik_a = 44;
            int masodik_b = 16;
            int masodik = MasodikFeladat(masodik_a, masodik_b);
            Console.WriteLine($"Ezekkel számolva: ({masodik_a}, {masodik_b}), a két szám legkisebb közös többszöröse: {masodik}");
            Console.WriteLine("===========================================================================================\n");




            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tHarmadik feladat");
            Console.Write("Adja meg c1 értékét!: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("Adja meg c2 értékét!: ");
            int c2 = int.Parse(Console.ReadLine());
            Console.Write("Adja meg c3 értékét!: ");
            int c3 = int.Parse(Console.ReadLine());
            Console.Write("Hanyadik elemet szeretné kiszámitani?: ");
            int n = int.Parse(Console.ReadLine());

            int fibonacci = HarmadikFeladat(n, c1,c2,c3);
            Console.WriteLine($"A Fibonacci sorozat {n} eleme: {fibonacci}");
            Console.WriteLine("===========================================================================================\n");




            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tNegyedik feladat");
            double a = 32;
            double negyedik_n = 6;
            double x = 4;

            double result = szamol(a, negyedik_n, x);
            Console.WriteLine($"Ezekkel a számokkal ({a}, {negyedik_n}, {x}) számolva az eredmény: {result}");
            Console.WriteLine("===========================================================================================");


            Console.ReadLine();
        }

        #region ElsoFeladat
        public static double ElsoFeladat(double i)
        {
            /* Feladat leírás
             ́Irjon rekurzıv fuggvenyt az alabbi keplet alapjan!

aˇi =
{
8, ha i = 0
5, ha i = 1
(aˇi-1^2 + 2 * aˇi−2)/10  egyébként
             */

            if (i == 0)
            {
                return 8;
            }
            if (i == 1)
            {
                return 5;
            }
            else
            {
                double a_i_1 = ElsoFeladat(i - 1);
                double a_i_2 = ElsoFeladat(i - 2);
                return (a_i_1 * a_i_1 + 2 * a_i_2) / 10;
            }
        }
        #endregion

        #region MasodikFeladat
        public static int MasodikFeladat(int a, int b)
        {
            /* Feladat leírás
         ́Irjon egy (rekurzıv) fuggvenyt, amely kiszamıtja ket szam legkisebb kozos tobbszoroset! A szamıtashoz
hasznalhatja a kovetkezo osszefuggest:

        lkkt (a, b) = (a*b)/lnko (a,b)

A legnagyobb kozös oszto meghatarozasahoz barmelyik eljarast hasznalhatja.
         */

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int LKT(int a, int b)
        {
            int lkt = MasodikFeladat(a, b);
            return (a * b) / lkt;
        }
        #endregion

        #region HarmadikFeladat
        public static int HarmadikFeladat(int n, int c1, int c2, int c3)
        {
            /* Feladat leírás
        ́Irjon egy rekurzıv algoritmust az altalanosıtott Fibonacci sorozat elemeinek meghatarozasara! A program 
       kerjen be harom egesz szamot (c1, c2, c3)  ́es ezek segıtsegevel keszıtse el a sorozatot:

aˇ0 = 1
aˇ1 = cˇ1
aˇn = cˇ2 * aˇn−2 + cˇ3 * aˇn−1   ha n ≥ 2
       */
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return c1;
            }
            else
            {
                int aminus2 = HarmadikFeladat(n-2,c1,c2,c3);
                int aminus1 = HarmadikFeladat(n-1,c1,c2,c3);
                return c2 * aminus2 + c3 * aminus1;
            }
        }
        #endregion

        #region NegyedikFeladat

        /* Feladat leírás
         Adott az alabbi eljaras. Kiadjuk a szamol(32,6,4) utasıtast. Mennyi a visszaadott  ́erteke a visszateres utan?

        1  szamol(a,n,x)
        2  IF n=0
        3  THEN RETURN x
        4  ELSE szamol (a, n-1, x/2 + a/2x)
 */

        public static double szamol(double a, double n, double x)
        {
            if(n == 0)
            {
                return x;
            }
            else
            {
                return szamol(a, n - 1, x / 2 + a / 2*x);
            }
        }

        #endregion
    }
}