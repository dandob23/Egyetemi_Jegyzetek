using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep_type_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot:");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot:");
            int szam2 = int.Parse(Console.ReadLine());
            int osszeg = szam1 + szam2;
            Console.WriteLine("\nA {1} és {2} számok összege: {0}", osszeg, szam1, szam2);
            int kivonas = szam1 - szam2;
            Console.WriteLine("A {1} és {2} számok különbsége: {0}", kivonas, szam1, szam2);
            int szorzat = szam1 * szam2;
            Console.WriteLine("A {1} és {2} számok szorzata: {0}", szorzat, szam1, szam2);
            int hanyados = szam1 / szam2;
            Console.WriteLine("\nA {1} és {2} számok hányadosa: {0}", hanyados, szam1, szam2);
            int maradek = szam1 % szam2;
            Console.WriteLine("A {1} és {2} számok maradéka: {0}", maradek, szam1, szam2);
            double real = Math.Round((double)szam1 / szam2, 2);
            Console.WriteLine("\nA {1} és {2} számok hányadosa(tört): {0}", real, szam1, szam2);
            double hatvany = Math.Pow(szam1, szam2);
            Console.WriteLine("A {1} és {2} számok hatványa: {0}", hatvany, szam1, szam2);
            Console.ReadLine();
        }
    }
}
