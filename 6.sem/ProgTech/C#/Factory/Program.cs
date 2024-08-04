using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = Point.Factory.CreateDescartesPoint(10, 20);
            Point p2 = Point.Factory.CreatePolarPoint(1, Math.PI / 2);
            Console.WriteLine();
            
            Console.ReadLine();
        }
    }
}
