using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proba
{
    class Film
    {
        public string rendezo, filmcim, kategoria;
        public DateTime premier;
        public double ertekeles;
        public int korhatar;
        public bool feliratos;
    }
   
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Film> lista = new List<Film>();
            string[] sorok = File.ReadAllLines("filmek.csv");
            foreach(string sor in sorok)
            {
                string[] mezok = sor.Split(';');
                Film f = new Film();
                f.rendezo = mezok[0];
                f.filmcim = mezok[1];
                f.premier = new DateTime(int.Parse(mezok[2]), int.Parse(mezok[3]), int.Parse(mezok[4]));
                f.kategoria = mezok[5];
                f.ertekeles = double.Parse(mezok[6]);
                f.korhatar = int.Parse(mezok[7]);
                if (mezok[8] == "feliratos")
                {
                    f.feliratos = true;
                }
                else f.feliratos = false;

                lista.Add(f);
            }



            Console.ReadKey();

        }
    }
}
