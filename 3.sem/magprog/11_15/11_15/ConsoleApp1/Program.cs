using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MoviesList = Beolvas("input.csv");
            Kiir(MoviesList);

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
                Console.WriteLine("{0} {1} {2} {3} {4}",movies.Director,movies.Title,movies.Release,movies.AgeRating,movies.Sub);
            }
        }
    }
}
