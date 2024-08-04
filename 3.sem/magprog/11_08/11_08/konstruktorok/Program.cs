using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktorok
{
    internal class Program
    {

        public class Diak
        {
            public string Nev;
            public string SzulHely;

            public Diak()
            {

            }
            public Diak(string nev, string szulhely)
            {
                this.Nev = nev;
                this.SzulHely = szulhely;
            }

        }

        
        static void Main(string[] args)
        {
            Diak diak1 = new Diak("Dan", "Eger");
            Console.WriteLine("diák:{0}, születési hely:{1}",diak1.Nev,diak1.SzulHely);


            Console.WriteLine("---------------");
            List<Diak> diakLista = new List<Diak>();


            //for (int i = 0; i < 3; i++)
            //{
            //    Diak tempDiak = new Diak();
            //    Console.Write("Diák neve?: ");
            //    tempDiak.Nev = Console.ReadLine();

            //    Console.Write("Szülhely?: ");
            //    tempDiak.SzulHely = Console.ReadLine();

            //    diakLista.Add(tempDiak);
            //}
            //Console.WriteLine("----------------------");
            //foreach (Diak diakok in diakLista)
            //{
            //    Console.WriteLine(diakok.Nev);
            //    Console.WriteLine(diakok.SzulHely);

            //}
            Console.WriteLine("---------------------");

            List<Diak> Fodiaklista = Beolvas(3);
            Kiir(Fodiaklista);

            Console.ReadKey();
        }

        public static List<Diak> Beolvas(int ismetles)
        {
            List<Diak> tempdiakLista = new List<Diak>();
            for (int i = 0; i < ismetles; i++)
            {
                Console.Write("Add meg a diak nevet: ");
                string tempNev = Console.ReadLine();
                Console.Write("Add meg a szuletesi helyet: ");
                string tempSzulHely = Console.ReadLine();
                Diak tempDiak = new Diak(tempNev, tempSzulHely);
                tempdiakLista.Add(tempDiak);

            }
            return tempdiakLista;
        }

        public static void Kiir(List<Diak> inputlista)
        {

            foreach (Diak diakok in inputlista)
            {
                Console.WriteLine(diakok.Nev);
                Console.WriteLine(diakok.SzulHely);
            }


        }
        
    }
}
