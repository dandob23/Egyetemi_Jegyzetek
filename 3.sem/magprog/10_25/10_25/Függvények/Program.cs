using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Függvények
{
    internal class Program
    {
        static Random rnd =new Random();
     
        static void Main(string[] args)
        {
            string name = "Programmer_Dániel_Debussy420";
            string output = stringAdder(name);
            Console.WriteLine(output);


            int szamlalo = 50;
            List<int> kulsoLista = feltoltes(szamlalo);



            Console.ReadKey();
        }
        static string stringAdder(string inputName)
        {
            string temp = "Szia " + inputName;
            return temp;
        }

        static List<int> feltoltes(int hossz)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < hossz; i++)
            {
                tempList.Add(rnd.Next(0, 100));
            }
            return tempList;
        }
        static void maxKiirat(List<int> lista)
        {
            int temp = lista.First();
            for (int i = 1; i < lista.Count; i++)
            {
                if (temp < lista[i])
                {
                    temp = lista[i];
                }
            }
            Console.WriteLine("A legnagyobb szám a listában: {0}",temp);
        }
    }
}
