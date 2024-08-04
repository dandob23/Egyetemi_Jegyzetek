using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lista = new List<double>();
            StreamReader sr = new StreamReader("szamok.txt");
            string s = sr.ReadLine();
            while (s != null)
                {
                lista.Add(double.Parse(s));
                s = sr.ReadLine();
                }
            sr.Close();
            /*
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0} ", lista[i]);
            }
            */
            //összeg
            double sum = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                sum = sum + lista[i];
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Összeg: {0} ", sum);
            //darabszám
            int db = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                db++;
            }
            Console.WriteLine();
            Console.WriteLine("Darabszám: {0} ", db);
            //nullák száma
            int dbnulla = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == 0)
                {
                    dbnulla++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Nullák száma: {0} ", dbnulla);
            //első nagyobb, mint 100
            Console.WriteLine();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 100)
                {
                    Console.WriteLine("Amik nagyobbak, mint 100: {0} ", lista[i]);
                }
            }
            Console.ReadKey();
            }
    }
}
