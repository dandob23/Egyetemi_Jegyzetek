using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace probazh
{
    internal class Controller
    {
        public static Queue<Product> products = new Queue<Product>();
        static List<Producer> producers = new List<Producer>();
        static List<Consumer> consumers = new List<Consumer>();
        public static bool areProducersWorking = false;
        static int maxChipCount = 10000;

        static object queueLock = new object();
        
        public static bool TryProduceFast(Producer producer, Product product)
        {
            lock(queueLock)
            {
                if (products.Count < maxChipCount)
                {
                    products.Enqueue(product);
                    Console.WriteLine($"FastProducer({producer}) has added {product}...");
                    Monitor.PulseAll(queueLock);
                    return true;
                }
                else
                {
                    Console.WriteLine($"FastProducer({producer}) is waiting");
                    return false;
                }
            }
        }
        public static bool TryProduceSlow(Producer producer, Product product)
        {
            lock (queueLock)
            {
                if (products.Count < maxChipCount)
                {
                    products.Enqueue(product);
                    Console.WriteLine($"SlowProducer({producer}) has added {product}...");
                    Monitor.PulseAll(queueLock);
                    return true;
                }
                else
                {
                    Console.WriteLine($"SlowProducer({producer}) is waiting");
                    return false;
                }
            }
        }

        public static bool TryConsumeFast(Consumer consumer, out Product product)
        {
            product = null;

            lock (queueLock)
            {
                while (products.Count==0)
                {
                    if (!areProducersWorking)
                    {
                        Monitor.PulseAll(queueLock);
                        return false;
                    }
                    Console.WriteLine($"FastConsumer({consumer}) is waiting...");
                    Monitor.Wait(queueLock);
                }

                product = products.Dequeue();
                Monitor.PulseAll(queueLock);
                return true;
            }
        }


        public static bool TryConsumeSlow(Consumer consumer, out Product product)
        {
            product = null;

            lock (queueLock)
            {
                while (products.Count == 0)
                {
                    if (!areProducersWorking)
                    {
                        Monitor.PulseAll(queueLock);
                        return false;
                    }
                    Console.WriteLine($"SlowConsumer({consumer}) is waiting...");
                    Monitor.Wait(queueLock);
                }

                product = products.Dequeue();
                Monitor.PulseAll(queueLock);
                return true;
            }
        }

        
        public static void CheckProducerWorkingState()
        {
            foreach (Producer producer in producers) {
                if (producer.IsWorking)
                {
                    return;
                }
            }
            areProducersWorking=false;

            Console.WriteLine("All producers have finished. ");
        }

        public static void CreateConsumers(int consumerCount)
        {
            for (int i = 0; i < consumerCount; i++)
            {
                consumers.Add(new Consumer());
            }
        }

        public static void CreateProducers(int amountToProduce) {
            for (int i = 0; i < amountToProduce; i++)
            {
                producers.Add(new Producer(amountToProduce));
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
