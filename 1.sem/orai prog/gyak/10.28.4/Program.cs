using System;

namespace _10._28._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk programot, amely az alábbi számításokat valósítja meg.Egy százméteres 
            //futás résztvevője a táv feléig egyenletesen gyorsul,
            //majd az utolsó tíz méteren egyenletesen lassul.
            //A program kérje be a futó kezdő sebességét(m/ s) egy adott intervallumon belül
            //(3.00 - 5.00), és írja ki tíz méterenként a futó aktuális sebességét km/ h - ban!

            double sebesseg;
            Console.Write("Adja meg a futó kezdősebességét!: ");
            sebesseg = double.Parse(Console.ReadLine());

            while (sebesseg<3||sebesseg>5)
            {
                Console.WriteLine("A sebesség nem 3,00 m/s és 5,00 m/s között van!");
                break;
            }

           
            for (double sebesseg<3; sebesseg<5; sebesseg++)
            {
                Console.WriteLine("{0}",sebesseg);
                
            }
            
            
            Console.ReadKey();

        }
    }
}
