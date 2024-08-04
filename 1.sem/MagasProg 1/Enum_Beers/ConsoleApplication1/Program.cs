using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{   
    struct Beer
    {
        public string brand;
        public uint price;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Beer x;

            //péndányosítás (instantiation)
            x = new Beer();

            x.brand = "Amstel";
            x.price = 289;

            Beer y;
            y = x;

            x.price += 20;

            Console.WriteLine("{0}: {1}", x.brand, x.price);
            Console.WriteLine("{0}: {1}", y.brand, y.price);

            Console.ReadKey();
        }
    }
}
