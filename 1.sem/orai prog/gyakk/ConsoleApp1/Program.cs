using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class filmek
    {
        public string rendezo, filmcim, kategoria;
        public int ev, honap, nap, korhatar;
        public bool feliratos;
        public double ertekeles;
    }
    class Program
    {
        static List<filmek> film = new List<filmek>();
        static void Main(string[] args)
        {
            beol("filmek.csv", ';');



            Console.ReadKey();
        }
        static void beol(string fajlnev, char mezohatarolo)
        {
            StreamReader sr = new StreamReader(fajlnev);
            while(!sr.EndOfStream)
            {
                string sv = sr.ReadLine();
                string[] tomb = sv.Split(mezohatarolo);
                filmek f = new filmek();
                f.rendezo = tomb[0];
                f.filmcim = tomb[1];
                f.ev = int.Parse(tomb[2]);
                f.honap = int.Parse(tomb[3]);
                f.nap = int.Parse(tomb[4]);

            }
        }
    }
}
