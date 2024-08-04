using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> szavak = new List<string>() { "Ez ", "egy ", "lista ", "tele ", "szöveggel" };
            for (int i = 0; i < szavak.Count; i++)
            {
                Console.Write(szavak[i] );
            }
            Console.ReadKey();
        }        
    }
}
