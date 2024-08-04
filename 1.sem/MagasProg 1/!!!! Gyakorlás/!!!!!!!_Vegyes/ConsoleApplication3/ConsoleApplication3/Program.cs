using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Megall_Ha_Elert_Valamit
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<int> lista = new List<int>();
            Console.WriteLine("Add meg a végértéket:");
            int end = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Írd be a köv. elemet:");
                int x = int.Parse(Console.ReadLine());

                if (x == end)
                {
                    break;
                }

                lista.Add(x);
            }
            Console.WriteLine();
            foreach (int y in lista)
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
