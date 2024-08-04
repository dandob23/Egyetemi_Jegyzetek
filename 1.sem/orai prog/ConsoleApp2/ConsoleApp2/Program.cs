using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random r = new Random();
            //int[] t = new int[100];
            //for (int i = 0; i < 10000; i++)
            //{
            //    int n = r.Next(10, 100);
            //    t[n]++;
            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    if (t[i] > 0)
            //    {
            //        Console.WriteLine("{0}. {1} db", i, t[i]);
            //    }
            //}

            Random r = new Random();
            int n = r.Next(90,100);
            for (int i = 0; i < 10; i++)
            {
                

                
            }
            for (int i = 0; i < 10; i++)
            {
                int m=1;
                m++;

                Console.WriteLine("{0}. {1}",m,n);
            }





            Console.ReadKey();
        }
    }
}
