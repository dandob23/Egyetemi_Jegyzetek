using System;

namespace gyak_2021_10_24
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            int[] tomb;
            tomb = new int[5];
            Console.WriteLine("A tömb elemszáma: {0}", tomb.Length);

            tomb[0] = rnd.Next(-10, 11);

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-10, 11);
            }

            double tombAtlag = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tombAtlag = tombAtlag + tomb[i];
            }

            tombAtlag = tombAtlag / tomb.Length;

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("tomb[{0}] = {1}, ", i+1, tomb[i]);
            }
            Console.Write("atlag = {0}",tombAtlag);
            
            Console.ReadKey();
        }
    }
}
