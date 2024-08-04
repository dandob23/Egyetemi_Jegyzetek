using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primek_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            for (int i = 1; i < 721; i++)
            {
                szamok.Add(i);
            }
            //for (int i = 0; i < szamok.Count; i++)
            foreach (int x in szamok)
            {
                //int x = szamok[i];
                int osztok = 0;
                for (int j = 1; j <= x; j++)
                {
                    if (x % j == 0)
                    {
                        osztok++;
                    }
                }
                if (osztok == 2)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }
    }
}
