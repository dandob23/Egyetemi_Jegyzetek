using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Consumer
    {
        static uint ID;
        uint id;
        int wineCount;
        WineType wineType;
        int csomagolasIdo;


        public uint Id { get => id; set => id = value; }
        internal WineType WineType { get => wineType; set => wineType = value; }

        public Consumer(int csomagolasIdo)
        {
            id = ID++;
            this.csomagolasIdo = csomagolasIdo;
        }

        public void Work()
        {
            Product product = null;
            wineCount = 0;
            while (Controller.wines.Count > 0 || Controller.areProducersWorking)
            {
                if (Controller.TryConsume(this, out product))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{this} elfogyasztotta ezt: {product}...");
                    Console.ForegroundColor = ConsoleColor.White;
                    wineCount++;
                }
                if (wineCount == 50)
                {
                    Thread.Sleep(csomagolasIdo);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{this} csomagolt egy üveget ebből: {product.WineType}!");
                    Console.ForegroundColor = ConsoleColor.White;
                    wineCount = 0;
                    wineType = WineType.NONE;
                }
                product = null;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this} abbahagyta a fogyasztást...");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override string ToString()
        {
            return $"Fogyasztó {id}";
        }

    }
}
