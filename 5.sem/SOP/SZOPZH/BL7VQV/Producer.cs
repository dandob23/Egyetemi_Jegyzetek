using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Producer
    {
        
        static uint ID;
        uint id;
        int amountToProduce;
        int wineCount;
        bool isWorking;
        int toltesIdo = 2;
        int cimkeIdo = 1;
        double dugozasIdo = 0.5;
        WineType wineType;


        public bool IsWorking { get => isWorking; set => isWorking = value; }
        
        public Producer(int amountToProduce, int toltesIdo, int cimkeIdo, double dugozasIdo, WineType wineType)
        {
            id = ID++;
            this.amountToProduce = amountToProduce;
            this.toltesIdo = toltesIdo;
            this.cimkeIdo = cimkeIdo;
            this.dugozasIdo= dugozasIdo;
            isWorking = false;
            this.wineType = wineType;
        }

        public void Work()
        {
            wineCount = 0;
            isWorking = true;
            Product product = null;
            while (wineCount < amountToProduce)
            {
                if (product == null)
                {
                    product = new Product(wineType);
                }
                if (Controller.TryProduce(this, product))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    wineCount++;
                    Console.WriteLine($"{this} teletöltötte a palackot...");
                    Thread.Sleep(toltesIdo);
                    Console.WriteLine($"{this} felcímkézte a palackot...");
                    Thread.Sleep(cimkeIdo);
                    Console.WriteLine($"{this} ledugózta a palackot...");
                    Thread.Sleep((int)dugozasIdo);
                    Console.WriteLine($"{this} elkészítette ezt: {product}!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("========================================");
                    product = null;

                }
            }
            isWorking = false;
            Controller.CheckProducerWorkingState();
            Console.WriteLine($"{this} abbahagyta a termelést...");
        }

        public void WineChanger()
        {
            int wineAmount = 0;
            while (wineCount < amountToProduce)
            {
                if (wineAmount == 50)
                {
                    switch (wineType)
                    {
                        case WineType.CABERNET_FRANC_2018:
                            wineType = WineType.EGRI_CSILLAG_2022;
                            break;
                        case WineType.EGRI_CSILLAG_2022:
                            wineType = WineType.CABERNET_FRANC_2018;
                            break;
                    }
                    wineAmount = 0;
                }
                wineAmount++;
            }
            
        }

        public override string ToString()
        {
            return $"Termelő {id}";
        }

    }
}
