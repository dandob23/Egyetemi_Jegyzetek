using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            StreamReader sr = new StreamReader("paros.txt");
            string s = sr.ReadLine();
            while (s!=null)
            {
                lista.Add(int.Parse(s));
                s = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0} ", lista[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Elemek száma: {0}", lista.Count);
            Console.ReadKey();
        }
    }
}
