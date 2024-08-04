using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MoviesList = Beolvas("input.csv");
            Kiir(MoviesList);
            KedvencRendezo(MoviesList);
            KinemAdott(MoviesList);

            Console.ReadKey();
        }

        public static List<Movie> Beolvas(string filename)
        {
            StreamReader SR = new StreamReader(filename, Encoding.GetEncoding("iso-8859-2"));
            List<Movie> inputList = new List<Movie>();

            while (!SR.EndOfStream)
            {
                Movie tempMovie = new Movie();
                string[] splitter = SR.ReadLine().Split(';');
                tempMovie.Director = splitter[0];
                tempMovie.Title = splitter[1];
                tempMovie.Release = new DateTime(int.Parse(splitter[2]), int.Parse(splitter[3]), int.Parse(splitter[4]));
                tempMovie.AgeRating = int.Parse(splitter[5]);
                if (splitter[6] == "feliratos")
                {
                    tempMovie.Subtitle = Sub.feliratos;
                }
                else
                {
                    tempMovie.Subtitle = Sub.nem_feliratos;

                }
                inputList.Add(tempMovie);
            }
            SR.Close();
            return inputList;
        }

        public static void Kiir(List<Movie> Input)
        {
            foreach (Moive movie in Input)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", movies.Director, movies.Title, movies.Release, movies.AgeRating, movies.Subtitle);
            }
        }

        public static void KedvencRendezo(List<Movie> Input)
        {
            Console.WriteLine("add meg a kedvenc rendezod: ");
            string favDirector = Console.ReadLine();
            bool logicDirector = false;
            foreach (Movie movies in Input)
            {
                if (movies.Director == favDirector)
                {
                    Console.WriteLine("{0} {1}",movies.Director,movies.Title);
                }
            }
        }

        public static void KinemAdott(List<Movie> input)
        {
            foreach (Movie movie in input)
            {
                if (movie.Release>DateTime.Now)
                {
                    Console.WriteLine("{0}",movie.Title);
                }
            }
        }

        public static void Mentes(List<Movie> input)
        {
            StreamWriter SW = new StreamWriter("output.csv",false,Encoding.UTF8);

            Movie tempMovie = new Movie();
            Console.WriteLine("Kérem adja meg a rendező nevét:");
            tempMovie.Director = Console.ReadLine();
            Console.WriteLine("Filmcím:");
            tempMovie.Title = Console.ReadLine();
            Console.WriteLine("Megjelenési dátum (hh/nn/év):");
            tempMovie.Release = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Korhatár:");
            tempMovie.AgeRating = int.Parse(Console.ReadLine());
            Console.WriteLine("Feliratos?:");
            if (Console.ReadLine()=="feliratos")
            {
                tempMovie.Subtitle = Sub.feliratos;
            }
            else
            {
                tempMovie.Subtitle = Sub.nem_feliratos;
            }

            foreach (Movie movie in input)
            {
                SW.WriteLine("{0};{1};{2};{3};{4};",movie.Director,movie.Title,movie.Release,movie.AgeRating,movie.Subtitle);
            }
            SW.Flush();
            SW.Close();
        }
    }
}
