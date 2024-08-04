using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soltinak_app_1
{
    class Program
    {
       
        static bool Oszthato(List<int> lista)
        {
            bool oszt = false;
            for (int i = 0; i < lista.Count; i++)
                if ((lista[i] % 10 == 0) && (lista[i] % 3 != 0))
                    oszt = true;                
                    return oszt;
        }
        static void Main(string[] args)
        {            
            List<int> lista = new List<int>() { 1, 2, 21 };
            Console.WriteLine(Oszthato(lista));
            Console.ReadKey();
        }
    }
}
