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
            //List<int> I = new List<int>();
            //Console.Write("Add meg a végértéket!: ");
            //int endValue = int.Parse(Console.ReadLine());
            //while (true)
            //{
            //    Console.Write("Add meg a köv. elemet: ");
            //    int x = int.Parse(Console.ReadLine());
            //    if (x == endValue) break;

            //    I.Add(x);
            //}




            int[] a = new int[] { 2, 3, 5, 6, 88 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}, ",a[i]);
                Console.WriteLine("{0}",1);
            }
            

            Console.ReadKey();
        }
    }
}
