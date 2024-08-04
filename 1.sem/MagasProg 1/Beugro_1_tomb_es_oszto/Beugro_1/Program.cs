using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beugro_1
{
    class Program
    {
        //Tömböt meg egy egész számot kap egy függvény , ami megnézi hogy tömb[i] % egész_szám == 0 és ha igen tegye egy listába a tömb[i]-t és listát ad vissza a fv

        static List<int> lista = new List<int>();
        
        static List<int> Beugro(int[] tomb, int szam)
        {
            for (int i=0; i < tomb.Length; i++)
            
                if (tomb[i] % szam == 0)
                
        lista.Add(tomb[i]);
        return lista;
                
                
           
        }
        static void Main(string[] args)
        {
            int[] tomb = new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Beugro(tomb, 3);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0},", lista[i]);
            }


            Console.ReadKey();       
        }
    }
}
