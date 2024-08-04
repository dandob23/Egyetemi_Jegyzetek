using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace zh
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.ReadLine();
        }

        public static List<Film>  Beolvas(string filenev)
        {
            StreamReader SR = new StreamReader(filenev,Encoding.Default);
            List<Film> output = new List<Film>();
            while (!SR.EndOfStream)
           	{
                Film tempfilm = new Film();
                string[] darabolt = SR.ReadLine().Split(';');
                tempfilm.Rendezo = darabolt[0];
                tempfilm.Megjelenes = darabolt[1];
                tempfilm.Kategoriak = new DateTime(int.Parse(darabolt[2]), int.Parse(darabolt[3]), int.Parse(darabolt[4]));
                tempfilm.Imdb = double.Parse
        	}

        }
    }
}
