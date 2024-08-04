using System;
using System.Collections.Generic;
using System.Linq;

namespace ZH_A
{
    class Program
    {
        #region Első
        /*
            Függvény A(i : egész) : egész
                Algoritmus:
                    Ha ( i = 0 ) Akkor A <- 7;
                    Különben Ha ( i = 1 ) Akkor A <- 3;
                    Különben Ha ( i = 2 ) Akkor A <- 5;
                    Különben
                        Ha ( i MOD 2 = 0 ) Akkor A <- (A(i - 3) + A(i - 2)) * (A(i - 3) + A(i - 2)) + A(i - 1);
                        Különben A <- (A(i - 3) - A(i - 2)) * (A(i - 3) - A(i - 2)) - A(i - 1)
                        HVége;
                    HVége;
            FVége;
        */
        static int A(int i)
        {
            if (i == 0) return 7;
            else if (i == 1) return 3;
            else if (i == 2) return 5;
            else
            {
                if (i % 2 == 0) return ((A(i - 3) + A(i - 2)) * (A(i - 3) + A(i - 2)) + A(i - 1));
                else return ((A(i - 3) - A(i - 2)) * (A(i - 3) - A(i - 2)) - A(i - 1));
            }
        }
        #endregion

        #region Második
        /*
            Függvény Szorzás(a : egész, b : egész) : egész
                Algoritmus:
                    Ha ( b = 0 ) Akkor Szorzás <- 0;
                    Különben
                        Ha ( b == 1) Akkor 
                            Szorzás <- a;
                        HVége;
                        Szorzás <- a + Szorzás(a, b - 1);
                    HVége;
            FVége;
        */
        static int Szorzas(int a, int b)
        {
            if (b == 0) return 0;
            else
            {
                if (b == 1) return a;
                return a + Szorzas(a, b - 1);
            }
        }
        #endregion

        #region Harmadik
        /*
         Eljárás MaxKivRend( a : Egész lista )
            Változók:
                Maximum : egész;
            Algoritmus:
                Ha (a elemszáma > 1) Akkor
                    Maximum := a.Max;
                    a.Törlés(Maximum);
                    MaxKivRend <- a;
                    a.Betesz(1, Maximum);
          EVége;

        */
        static void MaxKivRend(List<int> a)
        {
            if (a.Count > 1)
            {
                int Maximum = a.Max();
                a.Remove(Maximum);
                MaxKivRend(a);
                a.Insert(0, Maximum);
            }
        }
#endregion

        static void Kiir(List<int> a)
        {
            for (int i = 0; i < a.Count(); i++)
            {
                if (i == a.Count() - 1)
                {
                    Console.Write("" + a[i]);
                }
                else
                {
                    Console.Write("{0}; ", a[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 7, 3, 1, 4, 2, 6 };

            Console.WriteLine("Első feladat: A_6 értéke = " + A(6));
            Console.WriteLine("\nMásodik feladat: 5*3 = " + Szorzas(5, 3));
            Console.Write("\nHarmadik feladat:\n\tEredeti lista elemei: ");
            Kiir(lista);
            Console.Write("\n\tRendezett lista elemei: ");
            MaxKivRend(lista);
            Kiir(lista);


            Console.ReadLine();
        }
    }
}
