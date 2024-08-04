using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beker_Megduplaz
{
    class Program
    {
        static int Input()
        {
            Console.WriteLine("Adj meg egy számot");
            int b = int.Parse(Console.ReadLine());
            return b;
        }
        
        static int Megduplaz()
        {
            int d = Input();
            d = d * 2;
            return d;
        }

        static void Main(string[] args)
        {
            //int x = Input();
            int y = Megduplaz();
            //Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
