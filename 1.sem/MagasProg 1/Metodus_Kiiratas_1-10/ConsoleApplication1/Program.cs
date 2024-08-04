using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Paros(int[] z)
        {
            int db = 0;
            for (int i = 0; i < 10; i++)
			    if (z[i] %2 ==0)
                    db++;
            return db;
        }
        
        
        
        static void Main(string[] args)
        {
            int[] t = new int[10];
            Feltolt(t);
            Kiir(t);
            Console.WriteLine("Páros számok: {0} db", Paros(t));
            Console.ReadKey();
        }
        static void Kiir(int[] t)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("{0} ",t[i]);
        }
        static void Feltolt(int[] t)
        {
            for (int i = 0; i < 10; i++)
                t[i] = i + 1;
        }
        
    }
}
