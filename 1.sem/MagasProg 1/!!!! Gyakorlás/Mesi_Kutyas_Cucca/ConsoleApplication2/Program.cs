using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, kutyak_szama, Szempontok_szama, kiesett, max, maximum_kiesés = 0, kutyák=1;
            Random veletlen = new Random();
            Console.WriteLine("Hány kutya indul a versenyen?");
            kutyak_szama = int.Parse(Console.ReadLine());
            Console.WriteLine("Hány szempont van a versenyen?");
            Szempontok_szama = int.Parse(Console.ReadLine());

            int[,] Kutya = new int[kutyak_szama, Szempontok_szama];
            int[] kiesettek = new int[kutyak_szama];
            for (i = 0; i < kutyak_szama; i++)
            {
                for (j = 0; j < Szempontok_szama; j++)
                {
                    Kutya[i, j] = veletlen.Next(0, 10);
                }
            }
            Console.Write("\t");
            for (j = 0; j < Szempontok_szama; j++)
            {
                Console.Write("\t{0}.szempont", j + 1);
            }
            Console.Write("\n");
            for (i = 0; i < kutyak_szama; i++)
            {
                Console.Write("\n{0}.kutya", i + 1);
                for (j = 0; j < Szempontok_szama; j++)
                {
                    Console.Write("\t\t {0} p", Kutya[i, j]);
                }
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------------------");

            for (i = 0; i < kutyak_szama; i++)
            {
                kiesett = 0;
                for (j = 0; j < Szempontok_szama; j++)
                {
                    if (Kutya[i, j] < 5)
                    {
                        kiesett++;
                        kiesettek[i] = kiesett;
                    }

                }
                Console.Write("\n");
                Console.Write(" A(z) {0}. Kutya {1} kategóriából esett ki.", i + 1, kiesett);
                if (maximum_kiesés <= kiesett)
                {
                    maximum_kiesés = kiesett;
                }
                
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------------------");

            foreach (int érték in kiesettek)
            {
                if (érték == maximum_kiesés)
                {
                    Console.WriteLine("\n-------------------------------------------------");
                    Console.WriteLine("A(z) {0}. kutya esett ki a legtöbb kategóriából!!!", kutyák);
                }
                kutyák++;
            }
            
            
                        
            Console.ReadKey();
        }
    }
}
