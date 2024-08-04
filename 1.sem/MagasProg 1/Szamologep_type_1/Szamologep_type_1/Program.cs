using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep_type_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Összege: {0}", n1 + n2);
            Console.WriteLine("Különbsége: {0}", n1 - n2);
            Console.WriteLine("Szorzata: {0}", n1 * n2);
            Console.WriteLine("Hányadosa: {0}", n1 / n2);
            Console.ReadLine();
        }
    }
}
