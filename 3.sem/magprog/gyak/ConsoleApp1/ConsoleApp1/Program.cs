using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //keszitsen egy programot ami kiszamolja a dolgozat pontszámának átlagát ha a dolgozat max pontszáma 78

            //int dolgozatPontszam = 78;
            //int elertPontszam = 0;

            //Console.Write("Mennyi pontot értél el a dolgozatban?: ");
            //elertPontszam = int.Parse(Console.ReadLine());

            //do
            //{
            //    Console.Write("Helytelen pontszám. Adja meg újra");
            //    elertPontszam = int.Parse(Console.ReadLine());


            //} while (elertPontszam < 78 && elertPontszam > 0);


            //-------------_________________________________________________________------------------------------------------//
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("for:");
            Console.Write("adj meg szamot");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("{0}. ismetles", i + 1);
            }
            //-----------------------------//

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("while:");
            Console.Write("adj szamot");
            int input2 = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < input2)
            {
                sum += 2;
                Console.WriteLine("aktualis sum = {0}", sum);
            }
            //----------------------------//


            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("do-while:");

            bool temp = false;
            do
            {
                Console.WriteLine("adja meg a körszámot(522-678):");
                int laps = int.Parse(Console.ReadLine());

                if (laps > 522 && laps < 678)
                {
                    Console.WriteLine("helyes megadott körszám");
                    temp = true;
                }
                else
                {
                    Console.WriteLine("helytelen");
                }
            } while (temp != true);

            //-----------------------//

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("tömbök:");
            Console.WriteLine("tömb 1\r\n");
            string[] basearray = new string[3];
            basearray[0] = "asd";
            basearray[1] = "sda";
            basearray[2] = "das";
            for (int i = 0; i < basearray.Length; i++)
            {
                Console.WriteLine(basearray[i]);
            }

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;


            Console.WriteLine("-------");
            Console.WriteLine("tömb 2\r\n");
            string[] basearray2 = new string[]
            {
                "ferrari","volvo","porsche"
            };

            for (int i = 0; i < basearray2.Length; i++)
            {
                Console.WriteLine(basearray2[i]);
            }
            //_--------------------//

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("max");
            int[] numarray = new int[] { 32, 1212, 422, 5521, 563232, 12, 01, 3214, 21, 22 };

            int numtemp = numarray[0];

            for (int i = 0; i < numarray.Length; i++)
            {
                if (numtemp < numarray[i])
                {
                    numtemp = numarray[i];
                }
                Console.WriteLine(numarray[i]);
            }

            Console.WriteLine("max: {0}", numtemp);
            //---------------------------/

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("min");

            int[] numarray2 = new int[] { 12, 432, 6343, -6534, 123, 42, 0, 12, 1, 6546, -666 };

            int numtemp2 = numarray2[0];

            for (int i = 0; i < numarray2.Length; i++)
            {
                if (numtemp2 > numarray2[i])
                {
                    numtemp2 = numarray2[i];
                }
                Console.WriteLine(numarray2[i]);
            }

            Console.WriteLine("min: {0}", numtemp2);

            //------------------------------_______________________________________________________----------------------------------------------

            List<int> intLista = new List<int>();
            intLista.Add(10);
            intLista.Add(15);
            intLista.Add(20);
            intLista.Add(25);

            foreach (int szam in intLista)
            {
                Console.WriteLine(szam);
            }

            intLista.Clear();

            for (int i = 0; i < 10; i++)
            {
                intLista.Add(rnd.Next(0, 101));
            }

            for (int i = 0; i < intLista.Count; i++)
            {
                Console.WriteLine(intLista[i]);

            }

            Console.WriteLine("---------------------------------------");

            List<double> doubleLista = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                double egesz = rnd.Next(-1551, 13432);
                double tort = rnd.NextDouble();
                egesz += tort;
                doubleLista.Add(Math.Round(egesz, 2));
            }

            foreach (double szam in doubleLista)
            {
                Console.WriteLine(szam);
            }



            double max = doubleLista.First();
            double min = doubleLista.First();

            for (int i = 0; i < doubleLista.Count; i++)
            {
                if (max < doubleLista[i])
                {
                    max = doubleLista[i];
                }
                if (min > doubleLista[i])
                {
                    min = doubleLista[i];
                }
            }


            Console.WriteLine("Saját legnagyobb elem: {0}", max);
            Console.WriteLine("Saját legkisebb elem: {0}", min);
            Console.WriteLine("Belső max: {0}", doubleLista.Max());
            Console.WriteLine("Belső min: {0}", doubleLista.Min());
            Console.WriteLine("--------------------------");

            foreach (double szam in doubleLista)
            {
                Console.WriteLine(szam);
            }
            doubleLista.Sort();
            foreach (double szam in doubleLista)
            {
                Console.WriteLine(szam);
            }

            doubleLista.Reverse();
            foreach (double szam in doubleLista)
            {
                Console.WriteLine(szam);
            }

            Console.WriteLine("_-------------------_" +
                "____________________----Í_____");

            List<string> sLista = new List<string>();
            sLista.Add("sad");
            sLista.Add("dsa");
            sLista.Add("asd");



            foreach (string word in sLista)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("-----------___---__-__-_-__-_---------------");

            int szamlalo = 0;
            do
            {
                Console.WriteLine("szavak");
                sLista.Add(Console.ReadLine());
                szamlalo++;
            } while (szamlalo != 8);

            string[] wordtomb = sLista.ToArray();
            for (int i = 0; i < wordtomb.Length; i++)
            {
                Console.WriteLine(wordtomb[i]);
            }



            //tölts fel egy tömböt -23,5 es 789,8 között,1 utana, osszeg,átlag,
            //külső fügvény max,
            //min, allitsd sorrendbe majd ird ki azokat amik 10 es 13 között vannak



            //Console.WriteLine("A tömb számok: ");
            

            //double osszeg = 0;
            //double[] doubleTomb = new double[5];

            //for (int i = 0; i < doubleTomb.Length; i++)
            //{
            //    double ertek = rnd.Next(-500, 500) + rnd.NextDouble();
            //    doubleTomb[i] = Math.Round(ertek, 2);
            //    Console.WriteLine(doubleTomb[i] + "\r\n");
            //    osszeg = doubleTomb[i] + osszeg;
            //}
            //Console.WriteLine("-----------------------------\r\n");
            //double atlag;
            //atlag = osszeg / doubleTomb.Length;

            
            //Console.WriteLine("összeg: {0}", osszeg);
            //Console.WriteLine("\tátlag: {0}", atlag);

            //Console.WriteLine("-----------------------------\r\n");

            //double temp = doubleTomb[0];
            //for (int i = 0; i < doubleTomb.Length; i++)
            //{
            //    if (temp > doubleTomb[i])
            //    {
            //        temp = doubleTomb[i];
            //    }
            //}
            //Console.WriteLine("a min: {0}", temp);

            //Console.WriteLine("-----------------------------\r\n");

            //double temp2 = doubleTomb[0];
            //for (int i = 0; i < doubleTomb.Length; i++)
            //{
            //    if (temp2 < doubleTomb[i])
            //    {
            //        temp2 = doubleTomb[i];
            //    }
            //}
            //Console.WriteLine("a max: {0}", temp2);






            Console.ReadKey();  
        }
    }
}
