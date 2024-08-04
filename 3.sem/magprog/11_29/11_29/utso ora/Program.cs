using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zh_Kedd
    {

        class Film
        {
            public string Rendezo;
            public string Cim;
            public DateTime Megjelenes;
            public string[] Kategoriak;
            public double Imdb;
            public int Korhatar;
            public bool Felirat;

            public Film()
            {
            }

        } 
        class Program
        {
            static void Main(string[] args)
            {
                List<Film> AlapLista = Beolvas("ZH2 - input.csv");
                foreach (Film film in AlapLista)
                {
                    if (film.Megjelenes > DateTime.Now)
                    {
                        Console.WriteLine("{0} - {1} ({2})", film.Rendezo, film.Cim, film.Megjelenes.ToString("yyyy MMMM dd"));
                    }
                }
                Console.WriteLine("-------");
                Console.WriteLine("4.feladat");
                Console.WriteLine("Kérem adja meg a kedvenc rendezőjét: ");
                string inputRendezo = Console.ReadLine();
                if (KedvencRendezo(AlapLista, inputRendezo))
                {
                    foreach (Film film in AlapLista)
                    {
                        if (inputRendezo == film.Rendezo)
                        {
                            Console.WriteLine("{0} - {1}", film.Cim, film.Megjelenes.Year);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nincs ilyen rendező a listába");
                }
                Console.WriteLine("-------------");
                Console.WriteLine("6.feladat");
                List<Film> Output = new List<Film>();
                KategoriaLista(AlapLista, Output, "sci-fi");
                foreach (Film film in Output)
                {
                    if (film.Felirat == true)
                    {
                        Console.WriteLine("{0} - {1} (feliratos)", film.Rendezo, film.Cim);
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} (szinkronos)", film.Rendezo, film.Cim);
                    }
                }
                Console.WriteLine("---------");
                Console.WriteLine("7.feladat");
                Console.WriteLine("Kérem adja meg a film rendezőjét");
                inputRendezo = Console.ReadLine();
                Console.WriteLine("Kérem adja meg a film címét:");
                string inputFilmCim = Console.ReadLine();
                bool temp = false;
                for (int i = 0; i < AlapLista.Count; i++)
                {
                    if (AlapLista[i].Cim == inputFilmCim && AlapLista[i].Rendezo == inputRendezo)
                    {
                        AlapLista.RemoveAt(i);
                        temp = true;
                    }
                }
                if (!temp)
                {
                    Console.WriteLine("Nem töröltünk a listából");
                }

                Console.WriteLine("Kérem adja meg a legfiatalabb személy életkorát");
                int inputEletkor = int.Parse(Console.ReadLine());
                List<string> kedveltKateg = InputKategoriak();
                Console.WriteLine("Szóba jöhet-e feliratos film?");
                string inputFelirat = Console.ReadLine();
                bool tempCiklus = false;

                #region
                if (inputFelirat == "igen")
                {
                    foreach (Film film in AlapLista)
                    {

                        if (film.Korhatar <= inputEletkor)
                        {
                            for (int i = 0; i < film.Kategoriak.Length; i++)
                            {
                                for (int x = 0; x < kedveltKateg.Count; x++)
                                {
                                    if (film.Kategoriak[i] == kedveltKateg[x])
                                    {
                                        tempCiklus = true;

                                    }
                                }
                            }
                            if (tempCiklus == true)
                            {
                                Console.WriteLine("{0} - {1}", film.Rendezo, film.Cim);
                                tempCiklus = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (Film film in AlapLista)
                    {

                        if (film.Korhatar <= inputEletkor && film.Felirat == false)
                        {
                            for (int i = 0; i < film.Kategoriak.Length; i++)
                            {
                                for (int x = 0; x < kedveltKateg.Count; x++)
                                {
                                    if (film.Kategoriak[i] == kedveltKateg[x])
                                    {
                                        tempCiklus = true;

                                    }
                                }
                            }
                            if (tempCiklus == true)
                            {
                                Console.WriteLine("{0} - {1}", film.Rendezo, film.Cim);
                                tempCiklus = false;
                            }
                        }
                    }
                }
                #endregion

                List<string> kategoriaKereses = new List<string>();


                //elmentem a lehetséges kategóriakat
                foreach (Film film in AlapLista)
                {
                    bool vanEbenne = false;
                    for (int i = 0; i < film.Kategoriak.Length; i++)
                    {
                        for (int x = 0; x < kategoriaKereses.Count; x++)
                        {
                            if (film.Kategoriak[i] == kategoriaKereses[x])
                            {
                                vanEbenne = true;
                            }
                        }
                        if (!vanEbenne)
                        {
                            kategoriaKereses.Add(film.Kategoriak[i]);
                            vanEbenne = false;
                        }
                    }
                }

                List<Film> imdbBest = new List<Film>();
                Console.WriteLine("-------");
                for (int i = 0; i < kategoriaKereses.Count; i++)
                {
                    double kategMax = 0;
                    Film tempFilm = new Film();
                    foreach (Film filmek in AlapLista)
                    {
                        for (int x = 0; x < filmek.Kategoriak.Length; x++)
                        {
                            if (kategoriaKereses[i] == filmek.Kategoriak[x])
                            {
                                if (kategMax < filmek.Imdb)
                                {
                                    kategMax = filmek.Imdb;
                                    tempFilm = filmek;
                                }
                            }
                        }
                    }
                    imdbBest.Add(tempFilm);
                    kategMax = 0;
                }

                foreach (Film film1 in imdbBest)
                {
                    Console.WriteLine("{0} {1} {2}", film1.Rendezo, film1.Cim, film1.Imdb);
                }



                Console.ReadKey();
            }

            public static List<Film> Beolvas(string fileNev)
            {
                StreamReader SR = new StreamReader(fileNev, Encoding.Default);
                List<Film> output = new List<Film>();
                while (!SR.EndOfStream)
                {
                    Film tempFilme = new Film();
                    string[] darabolt = SR.ReadLine().Split(';');
                    tempFilme.Rendezo = darabolt[0];
                    tempFilme.Cim = darabolt[1];
                    tempFilme.Megjelenes = new DateTime(int.Parse(darabolt[2]), int.Parse(darabolt[3]), int.Parse(darabolt[4]));
                    tempFilme.Kategoriak = darabolt[5].Split(',');
                    tempFilme.Imdb = double.Parse(darabolt[6]);
                    tempFilme.Korhatar = int.Parse(darabolt[7]);
                    if (darabolt[8] == "feliratos")
                    {
                        tempFilme.Felirat = true;
                    }
                    else
                    {
                        tempFilme.Felirat = false;
                    }
                    output.Add(tempFilme);
                }
                SR.Close();
                return output;
            }

            public static bool KedvencRendezo(List<Film> input, string inRendezo)
            {
                foreach (Film film in input)
                {
                    if (film.Rendezo == inRendezo)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static void KategoriaLista(List<Film> Input, List<Film> Output, string kategoria)
            {
                foreach (Film film in Input)
                {
                    for (int i = 0; i < film.Kategoriak.Length; i++)
                    {
                        if (film.Kategoriak[i] == kategoria)
                        {
                            Output.Add(film);
                        }
                    }
                }
            }

            public static List<string> InputKategoriak()
            {
                string input = "";
                List<string> output = new List<string>();
                do
                {
                    Console.WriteLine("Kérem adja meg az egyik kategóriát:");
                    input = Console.ReadLine();
                    if (input != "vége")
                    {
                        output.Add(input);
                    }
                } while (input != "vége");
                return output;
            }


        }
}

    