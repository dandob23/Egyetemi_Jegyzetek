using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beugro_6_Listaban_oszthatosag
{
    class Program
    {
        //egy listát kap a fgv, döntse el h van-e benne 10-zel oszthato, de 3-mal nem osztható
        
        static bool vane = false;

        static bool Beugro6(List<int> lista)
        {            
            for (int i = 0; i < lista.Count; i++)
                if ((lista[i] % 10 == 0) && (lista[i] % 3 != 0))
                vane = true;
                return vane;
                
        }


        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Beugro6(lista);
            Console.WriteLine(vane);
            Console.ReadKey();
        }
    }
}
