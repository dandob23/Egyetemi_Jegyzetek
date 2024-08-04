using System;

namespace _10._28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írjunk programot, amely bekéri két pont koordinátáit, majd kiszámolja azok távolságát.

            //Segítség a megoldáshoz:
            //A távolság a két pont közé eső szakasz hossza, melyet a pontok koordinátáiból könnyedén
            //kiszámolhatunk.  
            //      √ (x1 − x2) ∗ (x1 − x2) +(y2 − y1) ∗ (y2 − y1)

            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            Console.Write("Adja meg az első koordinátát: ");
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a második koordinátát: ");
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            double tavolsag = 0;
            tavolsag = Math.Sqrt((x1 - x2) * (x1 - x2) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("A két koordináta távolsága: {0}", tavolsag);

            Console.ReadKey();
        }
    }
}
