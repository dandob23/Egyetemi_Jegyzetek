using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Program
    {
        static void KuldemenyekRogzitese(SzallitoVallalat vallalat, string file)
        {

            StreamReader sr = new StreamReader(file);

            if (!file.EndsWith(".csv"))
            {
                throw new Exception("Rossz kiterjesztés");
            }
            if (file!="kuldemenyek.csv")
            {
                throw new Exception("Rossz fájlnév");
            }

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                Kuldemeny ujKuldemeny = new Kuldemeny(int.Parse(adatok[0]), int.Parse(adatok[1]), int.Parse(adatok[2]),
                                                      double.Parse(adatok[3]),
                                                      adatok[4], adatok[5],
                                                      (BiztositasTipus)Enum.Parse(typeof(BiztositasTipus), adatok[6]));
                vallalat.Rogzit(ujKuldemeny);
            }
        }

        static void Main(string[] args)
        {
            SzallitoVallalat vallalat = new SzallitoVallalat();
            KuldemenyekRogzitese(vallalat, "kuldemenyek.csv");

            try
            {
                Kuldemeny kuldemeny1 = new Kuldemeny(1, 1, 1, 0.1, "1", "1", BiztositasTipus.Alap);
                
                Console.WriteLine("A 0,1kg-os küldemény: "+kuldemeny1);
            }
            catch (TomegAlacsonyException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (KuldemenyAlap kuldemeny in vallalat)
            {
                Console.WriteLine(kuldemeny);
            }

            //Console.WriteLine(SzallitoVallalat.Min(Kuldemeny));

            Console.WriteLine("---------------");

            foreach (KuldemenyAlap kuldemeny in vallalat.EunKivuliKuldemenyek)
            {
                Console.WriteLine(kuldemeny);
            }

            //foreach (KuldemenyAlap kuldemeny in )
            //{
            //    if (Id== "EP0057")
            //    {
            //        //48500 Ft alapján kötünk rá biztosítást, akkor szállítással és biztosítással együtt mennyit kell fizetni
            //    }
            //}



            Console.ReadLine();
        }
    }
}
