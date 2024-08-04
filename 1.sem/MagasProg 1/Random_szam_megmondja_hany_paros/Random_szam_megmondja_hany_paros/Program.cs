using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_szam_megmondja_hany_paros
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int db = 0;
            for (int i = 0; i < 100; i++)
            {
                int n = r.Next(10, 100);
                if (n % 2 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("{0} db páros szám volt", db);
            Console.ReadKey();

        }
    }
}
