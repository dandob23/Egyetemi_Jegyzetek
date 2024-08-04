using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while_for_if_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Kérjünk be 4 dalból álló album dalainak hosszát(perc-másodperc)
               Milyen hosszú az album? 
               Hanyadik helyen van a legrövidebb/leghosszabb          
            */
            string[] musicArray = new string[4];
            int tempCounter = 0;
            double sum = 0;
            int szamlalo=1;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            do
            {
                
                Console.Write("Kérem adja meg az {0}. szám hosszát(perc-másodperc): ",szamlalo);
                string input = Console.ReadLine();
                if (input != null)
                {
                    szamlalo++;
                }

                Console.WriteLine("-------------------------------------------------------");
                int minutes;
                int seconds;
                musicArray[tempCounter] = input;


                string[] tempArray = input.Split('-');
                bool logikaiMinutes = int.TryParse(tempArray[0], out minutes);
                bool logikaiSeconds = int.TryParse(tempArray[1], out seconds);
                if (logikaiMinutes && logikaiSeconds)
                {
                    sum += minutes;
                    sum += (double)seconds / 60;
                    tempCounter++;
                }
                else
                {
                    Console.WriteLine("Helytelen bemenet");
                    szamlalo--;
                }

                
            } while (tempCounter != 4);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;


            string[] tempSave = musicArray[0].Split('-');
            double tempActual = double.Parse(tempSave[0]) + (double.Parse(tempSave[1])) / 60;
            double min = tempActual;
            double max = tempActual;

            for (int i = 1; i < musicArray.Length; i++)
            {
                string[] tempFor = musicArray[i].Split('-');
                double temp = double.Parse(tempFor[0]) + (double.Parse(tempFor[1])) / 60;
                if (min > temp)
                {
                    min = temp;
                }
                if (max < temp)
                {
                    max = temp;
                }
            }

            //foreach (var i in musicArray)
            //{
            //    Console.Write("Megadott számok: ", musicArray[i]);
            //}
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("SUM                                                    ");
            Console.WriteLine("Az album hossza: {0} perc                 ", sum);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("MAX                                                    ");
            Console.WriteLine("A leghosszabb szám: {0} perc              ", max);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("MIN                                                    ");
            Console.WriteLine("A legrövidebb szám: {0} perc              ", min);
            Console.WriteLine("-------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
