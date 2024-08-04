using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futar
{
    class futar
    {
        public int het_nap, futarok, kilometer;
    }
    class Program
    {
        static List<futar> tabla = new List<futar>();
        static void Main(string[] args)
        {
                beol("tavok.txt", ' ');
            Console.WriteLine(fel_2());
            Console.ReadLine();
        }
        static void beol (string fajlnev, char mezohatar)
        {
            StreamReader sr = new StreamReader(fajlnev);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] sv = sor.Split(mezohatar);
                futar f = new futar();
                f.het_nap = int.Parse(sv[0]);
                f.futarok = int.Parse(sv[1]);

            }
        }
        static int fel_2()
        {
            int kilo = 0;
            for (int i = 0; i < tabla.Count; i++)
            {
                if (tabla[i].het_nap==1)
                {
                    tabla[i].kilometer = kilo;
                }
            }
            return kilo;
        }
    }
}
