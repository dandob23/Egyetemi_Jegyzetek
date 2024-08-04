using System;

namespace H009_Alprogramok
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 5, -10, 100, 8 };
            int[] b = new int[] { 8, 12, 19, -1000, -100, 23, 45 };

            //Console.Write("Tömb elemei: ");
            //for (int i = 0; i < a.Length - 1; i++)
            //    Console.Write("{0}, ", a[i]);
            //Console.WriteLine("{0}", a[a.Length - 1]);


            //Console.Write("Tömb elemei: ");
            //for (int i = 0; i < b.Length - 1; i++)
            //    Console.Write("{0}, ", b[i]);
            //Console.WriteLine("{0}", b[b.Length - 1]);

            Console.Write("Az a tömb elemeinek kiírása: ");
            TombKiir(a);

            Console.Write("A b tömb elemeinek a kiírása: ");
            TombKiir(b);

            Console.WriteLine("Az a tömb elemeinek az összege: {0}",osszeg(a));

            long bOsszeg = osszeg(b);

            Console.WriteLine("A b tömb elemeinek az összege: {0}",bOsszeg);
            

            int[] c = new int[0];
            Console.Write("A c tömb elemeinek az összege: {0}",osszeg(c));


            double cAtlag = atlag(c);
            if(cAtlag== double.MaxValue) Console.WriteLine("c tömb átlaga nem számítható ki");
            else Console.WriteLine("A c tömb átlaga: {0}",cAtlag);

            double aAtlag = atlag(a);
            if (aAtlag == double.MaxValue) Console.WriteLine("a tömb átlaga nem számítható ki");
            else Console.WriteLine("Az a tömb átlaga: {0}",aAtlag);
                      
            Console.ReadKey();
        }

        static double atlag(int[] t)
        {
            if (t.Length == 0) return double.MaxValue;
           
            return (double)osszeg(t) / t.Length;
        }
        static long osszeg(int[] t)
        {
            if (t.Length == 0) return -1;

            long osszeg = 0;
            for (int i = 0; i < t.Length; i++)
                osszeg += t[i];

            return osszeg;
                        
        }

        static void TombKiir(int[] tomb)
        {

            //Console.Write("Tömb elemei: ");
            for (int i = 0; i < tomb.Length - 1; i++)
                Console.Write("{0}, ", tomb[i]);
            Console.WriteLine("{0}", tomb[tomb.Length - 1]);
        }
    }
}
