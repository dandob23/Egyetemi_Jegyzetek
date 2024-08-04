using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Controller
    {
        public static List<Product> wines = new List<Product>();
        static List<Producer> producers = new List<Producer>();
        static List<Consumer> consumers = new List<Consumer>();
        public static bool areProducersWorking = false;
        static int maxWineCount = 20;

        public static bool TryProduce(Producer producer, Product product)
        {
            bool success = false;

            Monitor.Enter(wines);
            while (wines.Count >= maxWineCount)
            {
                Console.WriteLine($"{producer} várakozik...");
                Monitor.Wait(wines);
            }
            if (wines.Count < maxWineCount)
            {
                wines.Add(product);
                success = true;
            }
            Monitor.PulseAll(wines);
            Monitor.Exit(wines);

            return success;
        }

        public static bool TryConsume(Consumer consumer, out Product product)
        {
            bool success = false;
            product = null;

            Monitor.Enter(wines);
            foreach (var _consumer in consumers)
            {
                if (_consumer.Id != consumer.Id)
                {
                    switch (_consumer.WineType)
                    {
                        case WineType.CABERNET_FRANC_2018:
                            consumer.WineType = WineType.EGRI_CSILLAG_2022;
                            break;
                        case WineType.EGRI_CSILLAG_2022:
                            consumer.WineType = WineType.CABERNET_FRANC_2018;
                            break;
                    }
                }
            }
            while ((consumer.WineType == WineType.NONE && wines.Count == 0 && areProducersWorking) ||
                    (consumer.WineType != WineType.NONE && wines.Count > 0 && areProducersWorking && wines[0].WineType != consumer.WineType))
            {
                Console.WriteLine($"{consumer} várakozik...");
                Monitor.Wait(wines);
            }
            if (wines.Count > 0 && consumer.WineType == WineType.NONE)
            {
                product = wines.First();
                consumer.WineType = product.WineType;
                wines.Remove(product);
                success = true;
            }
            else if (wines.Count > 0 && consumer.WineType != WineType.NONE && wines.First().WineType == consumer.WineType)
            {
                product = wines.First();
                wines.Remove(product);
                success = true;
            }
            Monitor.PulseAll(wines);
            Monitor.Exit(wines);

            return success;
        }

        public static void CheckProducerWorkingState()
        {
            foreach (Producer producer in producers)
            {
                if (producer.IsWorking)
                {
                    return;
                }
            }
            areProducersWorking = false;
        }

        
        public static void CreateConsumers(int amount, int csomagolasIdo)
        {
            for (int i = 0; i < amount; i++)
            {

                consumers.Add(new Consumer(csomagolasIdo));
            }
        }
        public static void CreateProducers(int amount, int amountToProduce, WineType wineType, int toltesIdo, int cimkeIdo, double dugozasIdo)
        {
            for (int i = 0; i < amount; i++)
            {
                producers.Add(new Producer(amountToProduce, toltesIdo, cimkeIdo, dugozasIdo, wineType));
            }
        }

        public static void StartThreads()
        {
            areProducersWorking = true;
            foreach (var producer in producers)
            {
                new Thread(producer.Work).Start();
            }
            foreach (var consumer in consumers)
            {
                new Thread(consumer.Work).Start();
            }
        }
    }
}
