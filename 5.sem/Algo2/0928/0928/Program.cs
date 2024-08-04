using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0928
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Rekurzív 1)\n");
            for (int i = 1; i <= 10; i++)
            {
                double result1 = RekurzivEgy(i);
                Console.WriteLine($"\ta^{i} = {result1}\n");
            }



            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Rekurzív 2)\n");
            for (int j = 1; j <= 10; j++)
            {
                double result2 = RekurzivKetto(j);
                Console.WriteLine($"\ta^{j} = {result2}\n");
            }



            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Rekurzív 3)\n");
            for (int k = 1; k <= 10; k++)
            {
                double result3 = RekurzivHarom(k);
                Console.WriteLine($"\ta^{k} = {result3}\n");
            }



            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Fibonacci\n");
            for (int l = 0; l < 20; l++)
            {
                double result4 = Fibonacci(l);
                Console.WriteLine($"\tF^{l} = {result4}\n");
            }


            /*
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Fibonacci 2\n");
            for (int h = 0; h <= 10; h++)
            {
                double result5 = Fibonacci2(h);
                Console.WriteLine($"\tF^{h} = {result5}\n");
            }
            */

            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Fibonacci 3\n");
            for (int g = 0; g < 10; g++)
            {
                double result5 = Fibonacci3(g, 1, 1, 2, 3);
                Console.WriteLine($"\tF^{g} = {result5}\n");
            }

            Console.ReadLine();
        }

        static double RekurzivEgy(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                double nminusz1 = RekurzivEgy(n - 1);
                return ((nminusz1 * nminusz1) + (3 * nminusz1)) / 5;
            }
        }

        static double RekurzivKetto(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            if (n == 2)
            {
                return 5;
            }
            else
            {
                double nminusz1 = RekurzivKetto(n - 1);
                double nminusz2 = RekurzivKetto(n - 2);

                return (6 * (nminusz1 * nminusz1) + (4 * nminusz1) * nminusz2) / nminusz1;
            }
        }

        static double RekurzivHarom(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                double nminusz1 = RekurzivHarom(n - 1);

                return Math.Sqrt(4 * nminusz1 + 3);
            }
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int nminusz1 = Fibonacci(n - 1);
                int nminusz2 = Fibonacci(n - 2);
                return (nminusz1 + nminusz2);
            }
        }


        /*
        static double Fibonacci2(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                double gyok5 = Math.Sqrt(5);
                double nplusz1 = Fibonacci2(n + 1);
                return Math.Round
                    (1/gyok5 * ((1+gyok5)/2)*nplusz1);
            }
        }
        */

        static double Fibonacci3(int n, int C1, int C2, int d1, int d2)
        {
            if (n == 0)
            {
                return C1;
            }
            if (n == 1)
            {
                return C2;
            }
            else
            {

                return (d1 * (n - 1)) + (d2 * (n - 2));
            }
        }
    }
}
