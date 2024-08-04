using System;

namespace _10._28._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //készítsünk programot, amely kiszámolja sokszögek átlóit.
            //Az adatok bekérése után(szabályos háromszög, négyszög, ötszög, hatszög oldalai,
            //valamint azok magassága) kiszámolja az átlók hosszát.
            int oldal=1;
            double oldalhossz;
            do
            {
                Console.Write("Adja meg a sokszög {0}. oldalának hosszát, ha nincs több írja be a 0-át!: ", oldal);
                oldalhossz = double.Parse(Console.ReadLine());
                oldal++;

            } while ();

            double magassag = 0;
            Console.Write("Adja meg a sokszög magasságát!: ");
            magassag = double.Parse(Console.ReadLine());

            double atlo = 0;
            atlo = ((oldalhossz - 3) * oldalhossz) / 2;

            Console.WriteLine("A sokszögek átlója {0}", atlo);

            Console.ReadKey();
        }
    }
}
