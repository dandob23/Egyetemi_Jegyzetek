using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    internal class Program
    {
        public class Auto
        {
            public string Marka;
            public string Rendszam;
            public int elsoSuly;
            public int hatsoSuly;
            public int GyartasiEv;

            public Auto()
            {

            }

            public Auto(string marka, string rendszam, int elsosuly, int hatsosuly, int gyartasiev)
            {
                this.Marka = marka;
                this.Rendszam = rendszam;
                this.elsoSuly = elsosuly;
                this.hatsoSuly = hatsosuly;
                this.GyartasiEv = gyartasiev;
            }


            public int Eletkor()
            {
                return DateTime.Now.Year - this.GyartasiEv;
            }

            public int Osszsuly()
            {
                return this.hatsoSuly + this.elsoSuly;
            }
        }
        static void Main(string[] args)
        {
            
            Kiir(Beolvas(2));


            Console.ReadKey();
        }

        public static List<Auto> Beolvas(int ismetles)
        {
            List<Auto> tempAutok = new List<Auto>();

            for (int i = 0; i < ismetles; i++)
            {
                Console.Write("Az auto markaja: ");
                string marka = Console.ReadLine();

                Console.Write("Az auto rendszama: ");
                string rendszam = Console.ReadLine();

                Console.Write("Az elso tengely sulya: ");
                int elsotengely = int.Parse(Console.ReadLine());

                Console.Write("A hatso tengely sulya: ");
                int hatsotengely = int.Parse(Console.ReadLine());

                Console.Write("A gyartasi ev: ");
                int gyartasiEv = int.Parse(Console.ReadLine());

                tempAutok.Add(new Auto(marka, rendszam, elsotengely, hatsotengely, gyartasiEv));
            }

            return tempAutok;
        }

        public static void Kiir(List<Auto> tempAutok)
        {
            foreach (Auto autok in tempAutok)
            {
                Console.WriteLine(autok.Marka);
                Console.WriteLine(autok.Rendszam);
                Console.WriteLine(autok.elsoSuly);
                Console.WriteLine(autok.hatsoSuly);
                Console.WriteLine(autok.GyartasiEv);
                Console.WriteLine("Összsúly: {0}",autok.Osszsuly());
                Console.WriteLine("Életkor: {0}",autok.Eletkor());
                Console.WriteLine("----------------------------");

            }
        }
    }
}
