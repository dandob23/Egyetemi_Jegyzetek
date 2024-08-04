using System;

namespace _12._28._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.Write("Adja meg az első számot!: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Adja meg a második számot!: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("A két szám összege: {0}", a + b);
            Console.WriteLine("A két szám különbsége: {0}", a - b);
            Console.WriteLine("A két szám szorzata: {0}", a * b);
            Console.WriteLine("A két szám hányadosa: {0}", a / b);
            Console.WriteLine("A két szám átlaga: {0}", (a + b)/2);
            Console.WriteLine("A két szám maximuma: {0}", Math.Max(a,b));
            Console.WriteLine("A két szám minimuma: {0}", Math.Min(a,b));







            Console.ReadKey();
        }
    }
}
