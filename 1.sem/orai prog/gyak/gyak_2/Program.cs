using System;

namespace gyak_2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            byte letszam;
            bool sikeresBeolvasas;
            do
            {
                Console.Write("Kérem az osztály létszámát (min 10, max 255 fő): ");
                string sor = Console.ReadLine();
                sikeresBeolvasas = byte.TryParse(sor, out letszam);
            } 
            while (sikeresBeolvasas==false || letszam < 10 || 255 < letszam);

            byte maxPont;
            do
            {
                Console.Write("Kérem a dolg max pontszámát (min 5 pont és 2-vel osztható a pontszám) ");
                sikeresBeolvasas = byte.TryParse(Console.ReadLine(), out maxPont);

            } 
            while (!sikeresBeolvasas || maxPont < 5 || maxPont % 2 != 0);

            byte[] pontok = new byte[letszam];
            for (int i = 0; i < pontok.Length; i++)
            {
                pontok[i] = (byte)rnd.Next(0, maxPont + 1);
            }

            for (int i = 0; i < pontok.Length; i++)
            {
                double szazalek = Math.Round(pontok[i] / (double)maxPont * 100,2);

                byte erdemjegy;
                if (szazalek < 60) erdemjegy = 1;
                else if (szazalek < 70) erdemjegy = 2;
                else if (szazalek < 80) erdemjegy = 3;
                else if (szazalek < 90) erdemjegy = 4;
                else erdemjegy = 5;

                string erdemjegySzoveggel;
                switch (erdemjegy)
                {
                    case 1: erdemjegySzoveggel = "elégtelen";
                        break;
                    case 2: erdemjegySzoveggel = "elégséges";
                        break;
                    case 3: erdemjegySzoveggel = "közepes";
                        break;
                    case 4: erdemjegySzoveggel = "jó";
                        break;
                    default: erdemjegySzoveggel = "jeles";
                        break;
                }




                Console.WriteLine("Az {0}. tanuló pontszáma: {1}, érdemjegye: {2}({3}), százalék: {4}%",i+1,pontok[i], erdemjegySzoveggel, erdemjegy, szazalek);
            }

            ushort osszeg = 0;
            for (int i = 0; i < pontok.Length; i++)
            {
                osszeg = (ushort)(osszeg + pontok[i]);
            }
            double atlagPont = (double)osszeg / pontok.Length;
            Console.WriteLine("A dolgozaton elért átlag pontszám: {0}", atlagPont);

            byte atlagFelettiDb = 0;
            for (int i = 0; i < pontok.Length; i++)
            {
                if (atlagPont < pontok[i])
                {
                    atlagFelettiDb++;
                }
            }
            Console.WriteLine("A dolgozatban {0} fő ért el átlag feletti pontszámot!",atlagFelettiDb);

            byte minPont;
            minPont = pontok[0];
            for (int i = 1; i < pontok.Length; i++)
            {
                if (pontok[i] < minPont)
                {
                    minPont = pontok[i];
                }
            }
            Console.WriteLine("A dolgozatban min pontszám: {0}",minPont);

            int maxIndex = pontok.Length - 1;
            for (int j = maxIndex - 1; 0 <= j; j--) 
            {
                if (pontok[maxIndex] < pontok[j])
                {
                    maxIndex = j;
                }
            }
            Console.WriteLine("A dolgozatban elért max pontszám: {0}, tanulói sorszám: {1}",pontok[maxIndex], maxIndex+1);
            
            Console.ReadKey();
        }
    }
}
