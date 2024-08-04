using System;

namespace _10._28._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(3000 * r.NextDouble() - 1000);
            }

            Console.ReadKey();
        }
    }
}
