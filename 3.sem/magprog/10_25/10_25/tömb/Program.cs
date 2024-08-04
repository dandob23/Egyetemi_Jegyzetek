using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömb
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            double[] homersekletek = new double[168];
            for (int i = 0; i < homersekletek.Length; i++)
            {
                double ho = rnd.Next(22, 40) + rnd.NextDouble();
                homersekletek[i] = Math.Round(ho, 2);

            }

            int napCounter = 1;
            int oraCounter = 0;
            double kozepHo = 0;
            double maxHo = homersekletek[0];
            double minHo = homersekletek[0];

           
            for (int i = 0; i < homersekletek.Length; i++)
            {
                switch (oraCounter)
                {
                    case 1:
                        kozepHo += homersekletek[i];
                        break;

                    case 7:
                        kozepHo += homersekletek[i];
                        break;

                    case 13:
                        kozepHo += homersekletek[i];
                        break;

                    case 19:
                        kozepHo += homersekletek[i];
                        break;

                    default:
                        break;
                }
                oraCounter++;

                if (maxHo < homersekletek[i])
                {
                    maxHo = homersekletek[i];
                }
                if (minHo > homersekletek[i])
                {
                    minHo = homersekletek[i];
                }

           
                if (oraCounter==24)
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("A {0}. napi középhőmérséklet = {1} C°",napCounter,Math.Round(kozepHo/4,2));
                    Console.WriteLine("A {0}. napi maximum hőmérséklet = {1} C°",napCounter,maxHo);
                    Console.WriteLine("A {0}. napi minimum hőmérséklet = {1} C°", napCounter, minHo);
                    Console.WriteLine("A {0}. napi hőingadozás = {1} C°", napCounter, maxHo-minHo);
                    if (napCounter!=7)
                    {
                        maxHo = homersekletek[i + 1];
                        
                        minHo = homersekletek[i + 1];

                    }

                    kozepHo = 0;
                    oraCounter = 0;
                    napCounter++;
                }

                double hetiMax = homersekletek[0];
                double hetiMin = homersekletek[0];

                if (hetiMax < homersekletek[i])
                {
                    hetiMax = homersekletek[i];
                }
                if (hetiMin > homersekletek[i])
                {
                    hetiMin = homersekletek[i];
                }

                Console.WriteLine("A heti hőingadozás = {0} C°", hetiMax-hetiMin);

                //oraCounter = 0;
                //napCounter = 1;

                //Console.Write("Adja meg az intervallum első elemét!:");
                //int intervall = int.Parse(Console.ReadLine());
                //Console.Write("Adja meg az intervallum második elemét!:");
                //int intervall2 = int.Parse(Console.ReadLine());

                //double napiMin = homersekletek[intervall];
                //double intervallMin = napiMin;

                //for (int index = 0; index < homersekletek.Length; index++)
                {
                    //int minIndex = minHo;
                    //int maxIndex = maxHo;

                    //if (oraCounter >= intervall &&oraCounter<=intervall2)
                    //{
                    //    if (napiMin > homersekletek[i])
                    //    {
                    //        napiMin = homersekletek[i];
                    //    }
                    //}
                    //oraCounter++;   

                    //if (intervallMin>napiMin)
                    //{
                    //    intervallMin = napiMin;
                    //    minIndex = i;
                    //}

                    //if (oraCounter=24)
                    //{
                    //    oraCounter = 0;
                    //    napCounter++;
                    //}

                    //Console.WriteLine("Az intervallum");
                }

            }




            Console.ReadKey();
        }
    }
}


//google drive tinyurl.com/papai-share v vmi

 