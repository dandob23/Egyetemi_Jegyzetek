using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine("Ciklusok");
            Console.WriteLine("------------------------");
            Console.WriteLine("FOR: ");                                   //for
            Console.Write("Adj meg egy számot: ");
            int input=int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
			{
                Console.WriteLine("{0}. ismétlés",i+1);
			}


            //----------------------------------------------------------------------------------------------------//


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("------------------------");
            Console.WriteLine("WHILE: ");                                 //while
            Console.Write("Adj meg egy számot: ");

            int input2=int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum<input2)
            {
                sum+=2;
                Console.WriteLine("Aktuális sum = {0}",sum);
            }


            //----------------------------------------------------------------------------------------------------//


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("------------------------");
            Console.WriteLine("DO-WHILE: ");                              //do-while
            bool temp = false;
            do
	        {
                Console.WriteLine("Kérem adja meg a körszámot (44,78): ");
                int laps=int.Parse(Console.ReadLine());

                if (laps>43 && laps<79)
                {
                    Console.WriteLine("Helyes megadott körszám");
                    temp = true;
                }
                else
	            {
                    Console.WriteLine("Helytelen bemenet");
	            }
	            
	        } while (temp != true);


            //----------------------------------------------------------------------------------------------------//


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.WriteLine("TÖMBÖK: ");                                  //tömb

            Console.WriteLine("tömb_1");
            Console.WriteLine("");
            string[] basearray = new string[3];
            basearray[0] = "mercedes";
            basearray[1] = "audi";
            basearray[2] = "honda";

            for (int i = 0; i < basearray.Length; i++)
			{
                Console.WriteLine(basearray[i]);
			}

            Console.WriteLine("------------------------");
            Console.WriteLine("tömb_2");
            Console.WriteLine("");

            string[] basearray2 = new string[] { "ferrari", "volvo", "porsche", "renault" };

            for (int i = 0; i < basearray2.Length; i++)
            {
                Console.WriteLine(basearray2[i]);
            }


            //----------------------------------------------------------------------------------------------------//


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("------------------------");
            Console.WriteLine("MAXIMUM KIVÁLASZTÁS: ");

            int[] numArray = new int[] {43,654,786,12,45,63,7313,44,6672};
            Console.WriteLine("Belső függvény: {0}",numArray.Max());         //belső függvény    MAX


            int numTemp = numArray[0];
            for (int i = 1; i < numArray.Length; i++)
            {
                if (numTemp < numArray[i])
                {
                    numTemp = numArray[i];
                }
            }
            Console.WriteLine("Saját algoritmus = {0}",numTemp);            //saját függvény    MAX


            //----------------------------------------------------------------------------------------------------//


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------------");
            Console.WriteLine("MINIMUM KIVÁLASZTÁS: ");

            int[] numArray2 = new int[] {12,45,63,11245,1235,112,-12,10,11,1353,-44};
            Console.WriteLine("Belső függvény: {0}", numArray2.Min());         //belső függvény    MIN


            int numTemp2 = numArray2[0];
            for (int i = 1; i < numArray2.Length; i++)
            {
                if (numTemp2 > numArray2[i])
                {
                    numTemp2 = numArray2[i];
                }
            }
            Console.WriteLine("Saját algoritmus = {0}", numTemp2);            //saját függvény    MIN


            //----------------------------------------------------------------------------------------------------//


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------");
            Console.WriteLine("FOREACH: ");
            Console.WriteLine("Intes Array");

            foreach (int num in numArray2)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("Stringes Array");
            Console.WriteLine();
            string[] strArray = new string[] {"Peugeot", "Skoda", "Opel", "Kia"};

            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
