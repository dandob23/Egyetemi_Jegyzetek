using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zh -> rekurziv sorozatok(vmilyen formula, az alapján egy rekurziv sorozat(irasd ki az x elemet/elso tizet))+fibonacci jellegu
            //legnagyobb kozos oszto(matematikai) faktorialis stb stb
            //képlet/formula/pseudo kod, azt leprogramozni
            //listak sor verem

            Console.ForegroundColor = ConsoleColor.Green;
            //1_FELADAT
            Console.WriteLine("==========================================");
            Vsetkojedno(35, out double d);
            Console.WriteLine(d+"\n");
            Console.WriteLine("==========================================");


            //2_FELADAT
            Console.WriteLine("==========================================");
            Hanoi(3, 'a', 'c', 'b');
            Console.WriteLine();
            Console.WriteLine("==========================================");


            //3_FELADAT
            int[] A = {2,65,76,12,88,98,3,7,15,4};
            MinKivRend(A, 1, 10);
            


            Console.ReadKey();
        }
        static double Vsetkojedno(double a, out double d)
        {
            
            /*//a=35 mivel tér vissza, mennyi a hívások száma
             Vsetkojedno(a,d)
            if(a=0)
            then d<-0
            else Vsetkojedno(a Div2, d)
            d <- d+(aMOD2)
            return (d)
             */
            int szamlalo =0;
            if (a == 0)
            {
                d = 0;
            }
            else
            {
                Vsetkojedno(a / 2, out d);
                d = d + (a % 2);
                szamlalo++;
            }
            return d;
        }

        static int Hanoi(int n, char r1, char r3, char r2)
        {
            /*
             eljárás hanoi(n:egészl r1,r3,r2: karakter)
            algo
                ha n>0 akkor
                    hanoi(n-1,r1,r2,r3);
                    ki:n, "korong atrakasa", r1, ->, r3
                    hanoi(n-1,r2,r3,r1)
                ha vége
            evege
             */
            if (n>0)
            {
                Hanoi(n - 1, r1, r2, r3);
                Console.WriteLine("Korong átrakása " + r1 + " -> " + r3);
                Hanoi(n - 1, r2, r3, r1);
            }
            return n;
        }

        static int MinKivRend(int[] A, int mettol, int meddig)
        {
            if (mettol<meddig)
            {
                int min_index = mettol;
                for (int i = mettol + 1; i < meddig; i++)
                {
                    if (A[i] < A[min_index])
                    {
                        min_index = i;
                    }
                }
                A.
                MinKivRend(A, mettol + 1, meddig);
            }
            return A[0];
        }
        static  Csere(int mettol, int meddig)
        {
            List<int> cserelista = new List<int>();
            cserelista.Add(meddig);
            cserelista.Add(mettol);

        }
    }
}
