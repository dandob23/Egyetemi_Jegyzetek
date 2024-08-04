using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_Cim_Szerinti_Atadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            Console.WriteLine("1. {0}", a);
            ErtekSzerint(a, b);
            Console.WriteLine("2. {0}", a);
            CimSzerint(ref a, ref b);
            Console.WriteLine("3. {0}", a);
            int e;
            int f;
            OutFajta(out e, out f);
            Console.WriteLine("{0} {1}", e, f);
            Console.ReadKey();
        }
        static void ErtekSzerint(int a, int b)
        {
            a = a + b;
            Console.WriteLine(a);
        }
        static void CimSzerint(ref int a, ref int b)
        {
            a = a + b;
            Console.WriteLine(a);
        }
        static void OutFajta(out int x, out int z)
        {
            x = 8;
            z = 12;
        }
    }
}
