using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listak
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<int> intLista = new List<int>();
            intLista.Add(5);
            intLista.Add(6);
            intLista.Add(10);

            foreach (int szam in intLista)
            {
                Console.WriteLine(szam);
            }

            intLista.Clear();

            Console.WriteLine("---------------------------------------");

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
                double egesz = rnd.Next(-9, 10);
                double tort = rnd.NextDouble();
                egesz += tort;
                doubleLista.Add(Math.Round(egesz, 2));

            }

            foreach (double szam in doubleLista)
            {
                Console.WriteLine(szam);
            }

            Console.WriteLine("---------------------------------------");

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

            Console.WriteLine("Saját legnagyobb elem: {0}",max);
            Console.WriteLine("Saját legkisebb elem: {0}", min);
            Console.WriteLine("Belső max: {0}", doubleLista.Max());
            Console.WriteLine("Belső min: {0}", doubleLista.Min());

            Console.WriteLine("---------------------------------------");


            Console.WriteLine("Rendezetlen lista:");
            foreach (double szam in doubleLista)
            {
                Console.WriteLine(szam);
            }
            Console.WriteLine("Rendezett lista:");
            doubleLista.Sort();
            foreach (double szam in doubleLista)
            {
                Console.WriteLine(szam);
            }
            doubleLista.Reverse();
            Console.WriteLine("Csökkenő sorrend");
            foreach (double  szam in doubleLista)
            {
                Console.WriteLine(szam);
            }

            Console.WriteLine("---------------------------------------");

            List<string> stringLista = new List<string>();
            stringLista.Add("alma");
            stringLista.Add("barack");
            stringLista.Add("körte");
            stringLista.Add("avocado");
            stringLista.Insert(1,"dinnye");

            foreach (string gyümölcs in stringLista)
            {
                Console.WriteLine(gyümölcs);
            }

            Console.WriteLine("---------------------------------------");

            int szamlalo=0;
            do
            {
                Console.Write("Gyümöcsök: ");
                stringLista.Add(Console.ReadLine());
                szamlalo++;
            } while (szamlalo!=5);

            foreach (string gyümölcsök in stringLista)
            {
                Console.WriteLine(gyümölcsök);
            }


            string[] gyümölcsTömb = stringLista.ToArray();
            for (int i = 0; i < gyümölcsTömb.Length; i++)
            {
                Console.WriteLine(gyümölcsTömb[i]);
            }
            
            Console.ReadLine();
        }
    }
}
