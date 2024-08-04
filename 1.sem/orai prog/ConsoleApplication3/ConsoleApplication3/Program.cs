using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Film
    {
        public string rendezo;
        public string cim;
        public DateTime premier;
        public string kategoria;
        public double ertekeles;
        public int kohatar;
        public bool feliratos;
    }
    class Program
    {
        static List<string> feladat10(List<Film> lista)
        {
            List<string> kategoriak = new List<string>();

            foreach (Film f in lista)
            {
                if (f.premier < DateTime.Now)
                {
                    string k = f.kategoria;

                    bool benneVan = false;
                    foreach (string kat in kategoriak)
                    {
                        if (kat == k)
                        {
                            benneVan = true;
                            break;
                        }
                    }

                    if (!benneVan) kategoriak.Add(k);
                }
            }

            return kategoriak;
        }

        static List<string> feladat8()
        {
            List<string> kategoriak = new List<string>();
            string kategoria;
            do
            {
                Console.Write("Kérek egy kategóriát: ");
                kategoria = Console.ReadLine();

                if(kategoria.Length != 0 && kategoria != "vége")
                    kategoriak.Add(kategoria);
            }
            while(kategoria != "vége");

            return kategoriak;
        }
        static void feladat5(List<Film> lista, List<Film> lista2, string kategoria)
        {
            lista2.Clear();

            foreach (Film f in lista)
            {
                if (f.kategoria == kategoria)
                    lista2.Add(f);
            }
        }

        static bool feladat3(List<Film> lista, string rendezo)
        {
            foreach (Film f in lista)
            {
                if (f.rendezo == rendezo) return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            List<Film> lista = new List<Film>();
            string[] sorok = File.ReadAllLines("filmek.csv");
            foreach (string sor in sorok)
            {
                string[] mezok = sor.Split(';');
                Film f = new Film();
                f.rendezo = mezok[0];
                f.cim = mezok[1];
                f.premier = new DateTime(
                    int.Parse(mezok[2]),
                    int.Parse(mezok[3]),
                    int.Parse(mezok[4])
                );
                f.kategoria = mezok[5];
                f.ertekeles = double.Parse(mezok[6]);
                f.kohatar = int.Parse(mezok[7]);

                if (mezok[8] == "feliratos")
                    f.feliratos = true;
                else
                    f.feliratos = false;
                lista.Add(f);

            }


            DateTime ma = DateTime.Now; // akt. rendszeridő
            foreach (Film f in lista)
            {
                if (ma < f.premier)
                    Console.WriteLine("{0} - {1} ({2})", f.rendezo, f.cim, f.premier.ToString("yyyy MM dd"));
            }



            // feladat 4
            
            string rendezo;
            do
            {
                Console.Write("Kérem a rendező nevét: ");
                rendezo = Console.ReadLine();
            }
            while(rendezo.Length == 0);

            if (feladat3(lista, rendezo))
            {
                foreach (Film f in lista)
                {
                    if (f.rendezo == rendezo)
                    {
                        Console.WriteLine("({0}) {1} - IMDB: {2}", f.premier.Year, f.cim, f.ertekeles);
                    }
                }
            }
            else
            {
                Console.WriteLine("A rendezőhöz nem tartozik film!");
            }



            // feladat 6 
            List<Film> sciFik = new List<Film>();
            feladat5(lista, sciFik, "sci-fi");

            double osszeg = 0;
            foreach (Film f in sciFik)
            {
                string felirat = "feliratos";
                if (!f.feliratos) felirat = "szinkronos";

                /*
                string f2 = f.feliratos;
                if(f.feliratos != "feliratos") f2 = "szinkronos"
                */

                Console.WriteLine("{0} - {1} ({2})", f.rendezo, f.cim, felirat);
                osszeg += f.ertekeles;
            }

            if (sciFik.Count != 0)
            {
                Console.WriteLine("Átlagos értékelés: {0}", osszeg / sciFik.Count);
            }

            // 7 feladat
            do
            {
                Console.Write("Kérem a rendező nevét: ");
                rendezo = Console.ReadLine();
            }
            while (rendezo.Length == 0);

            string cim;
            do
            {
                Console.Write("Kérem a film címét: ");
                cim = Console.ReadLine();
            }
            while (cim.Length == 0);

            int index = -1;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].rendezo == rendezo && lista[i].cim == cim)
                {
                    index = i;
                    break;
                }
            }
            if(index == -1)
            {
                Console.WriteLine("Nincs ilyen film!");
            }
            else
            {
                lista.RemoveAt(index);
            }


            // 9 feladat 
            int eletkor; 
            do
            {
                Console.Write("Kérem az életkort: ");
            }
            while(!int.TryParse(Console.ReadLine(), out eletkor) || eletkor < 1);
            List<string> kategoriak = feladat8();

            bool feliratos = false;
            string feliratSor;
            do{
                Console.Write("Feliratos lehet (I/N)?");
                feliratSor = Console.ReadLine();

                if(feliratSor == "I") feliratos = true;
                else if(feliratSor == "N") feliratos = false;
            }
            while(feliratSor != "I" && feliratSor != "N");

            foreach (Film f in lista)
            {
                if (eletkor < f.kohatar) continue;
                if (feliratos == false && f.feliratos) continue;
                
                bool benneVan = false;
                foreach(string k in kategoriak)
                {
                    if (k == f.kategoria)
                    {
                        benneVan = true;
                        break;
                    }
                }
                if (!benneVan) continue;
                
                Console.WriteLine("{0} - {1} ({2} év) - {3}",
                    f.cim,
                    f.kategoria,
                    f.kohatar,
                    f.feliratos ? "feliratos" : "szinkronos"
                    );
            }

            // 11 felaat 

            List<string> kategoriak11 = feladat10(lista);

            foreach (string kategoria in kategoriak11)
            {
                Film maxFilm = null;
                foreach (Film f in lista)
                {
                    if(f.kategoria == kategoria && f.premier < DateTime.Now)
                    {
                        if (maxFilm == null) maxFilm = f;
                        else if (maxFilm.ertekeles < f.ertekeles) maxFilm = f;
                    }
                }

                Console.WriteLine("{0}: {1} - {2} ({3}", kategoria, maxFilm.rendezo, maxFilm.cim, maxFilm.ertekeles);
            }


            Console.ReadLine();
        }
    }
}
