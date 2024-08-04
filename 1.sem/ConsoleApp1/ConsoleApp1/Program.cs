using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        ;{
            Console.WriteLine("3 szám szorzó");
            double a = 0;
            double b = 0;
            double c = 0;

            Console.Write("Adja meg az a számot!: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Adja meg a b számot!: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Adja meg a c számot!: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("A három szám szorzata: {0}", a * b * c);


            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(" _______");
                Console.WriteLine("|       |");
                Console.WriteLine("| -   - |");
                Console.WriteLine("|  ___  |");
                Console.WriteLine("|_______|");
                Console.Write("Nice try buddy... ");
            }
            
            





            Console.ReadKey();
        }
    }
}
