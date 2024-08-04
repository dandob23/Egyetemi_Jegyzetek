using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hany_probalkozas_kell_h_megtalalja_99_et
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(10, 100);
            int db = 1;
            while (n != 99)
            {
                n = r.Next(10, 100);
                db++;
            }
            Console.WriteLine("{0}. ptóbálkozásra lett 99", db);
            Console.ReadKey();
        }
    }
}
