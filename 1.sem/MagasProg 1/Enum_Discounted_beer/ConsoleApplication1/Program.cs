using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        enum Brand : long
        {
            Kozel,
            Soproni,
            Kobanyai
        }
        class Beer
        {
            public Brand brand;
            public int volume;
            public float alc;
            public int price;
        }        
        static void Main(string[] args)
        {
            List<Beer> crate = new List<Beer>();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int brandValue = rnd.Next(3);
                Beer beer = new Beer()
                {
                    brand = (Brand) brandValue,
                    volume = 500,
                    alc = 4.8f,
                    price = 150
                };
                crate.Add(beer);
            }            
            foreach (Beer beer in crate)
            {                
                Console.WriteLine("Márka: {0}", beer.brand);
                Console.WriteLine("Űrtartalom: {0} ml", beer.volume);
                Console.WriteLine("Alkoholtartalom: {0} %", beer.alc);
                if (beer.brand == Brand.Kobanyai)
                {
                    Console.WriteLine("Ár: {0} Ft.", beer.price * 0.8);
                }
                else
                {
                    Console.WriteLine("Ár: {0} Ft.", beer.price);
                }                
            }            
            Console.ReadKey();
        }
    }
}
