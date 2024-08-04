using System;

class Program
{
    static void Main()
    {
        
        //Console.ForegroundColor = ConsoleColor.Cyan;
        //Console.WriteLine("\n======================== Legnagyobb közös osztó (1) ========================");
        //Console.Write("Adja meg az első egész számot (a): ");
        //int a = int.Parse(Console.ReadLine());
        //Console.Write("Adja meg a második egész számot (b): ");
        //int b = int.Parse(Console.ReadLine());
        //int lnko = LegnKozOszto(a, b);
        //Console.WriteLine($"A legnagyobb közös osztó ({a}, {b}) = {lnko}");
        //Console.WriteLine("============================================================================\n");


        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine("======================== Legnagyobb közös osztó (2) ========================");
        //Console.Write("Adja meg az első egész számot (a): ");
        //int a2 = int.Parse(Console.ReadLine());
        //Console.Write("Adja meg a második egész számot (b): ");
        //int b2 = int.Parse(Console.ReadLine());
        //int lnko2 = EuklLegnKozOszto(a2, b2);
        //Console.WriteLine($"A legnagyobb közös osztó ({a2}, {b2}) = {lnko2}");
        //Console.WriteLine("============================================================================\n");
        

        Console.ForegroundColor = ConsoleColor.Yellow;
        double k = 0;
        Console.WriteLine("======================== Legnagyobb közös osztó (3) ========================");
        Console.Write("Adja meg az első egész számot (a): ");
        int a3 = int.Parse(Console.ReadLine());
        Console.Write("Adja meg a második egész számot (b): ");
        int b3 = int.Parse(Console.ReadLine());
        int lnko3 = BinLegnKozOszto(a3, b3, k);
        Console.WriteLine($"A legnagyobb közös osztó ({a3}, {b3}) = {lnko3}");
        Console.WriteLine($"Ennyiszer volt mindkettő páros: {k}");
        Console.WriteLine("============================================================================\n");

        Console.ReadLine();
    }

    #region LEGNAGYOBB KÖZÖS OSZTÓ
    static int LegnKozOszto(int a, int b)
    {
        if (a < 0)
        {
            a = -a;
        }
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    #endregion

    #region EUKLIDESZI LEGNAGYOBB KÖZÖS OSZTÓ
    static int EuklLegnKozOszto(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            int temp = a % b;
            return EuklLegnKozOszto(b, temp);
        }
    }
    #endregion

    #region BINÁRIS LEGNAGYOBB KÖZÖS OSZTÓ
    static int BinLegnKozOszto(int a, int b, double k)
    {
        k = 0;
        if (b == 0)
        {
            return a;
        }
        else if (a >= b)
        {
            if (ParosE(a) && ParosE(b))
            {
                return 2 * BinLegnKozOszto(a / 2, b / 2, k++);
            }
            else if (ParosE(a) && !ParosE(b))
            {
                return BinLegnKozOszto(a / 2, b, k);
            }
            else if (!ParosE(a) && ParosE(b))
            {
                return BinLegnKozOszto(a, b / 2, k);
            }
            else
            {
                return BinLegnKozOszto(b, (a - b) / 2, k);
            }
        }
        else
        {
            return BinLegnKozOszto(b, a, Math.Pow(2,k)*a);
        }
    }
    static bool ParosE(int a)
    {
        if (a%2==0)
        {
            return true;    
        }
        return false;
    }
    #endregion
}