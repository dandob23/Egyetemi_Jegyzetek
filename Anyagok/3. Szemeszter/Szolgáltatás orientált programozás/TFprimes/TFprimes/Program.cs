using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TFprimes
{
    class Producer
    {
        int tol = 0; int ig = 0;

        public Producer(int from, int until)
        {
            this.tol = from; this.ig = until;
        }

        public void DoWork()
        {
            Supervisor.aProducerStarts();
            for (int i = tol; i < ig; i++)
                if (IsPrim(i))
                    Supervisor.Produce(i);

            Supervisor.aProducerStops();
        }

        bool IsPrim(int num)
        {
            bool prime = true;

            for (int i = 2; i <= Math.Sqrt(num) && prime; i++)
                if (num % i == 0)
                    prime = false;

            return prime;
        }
    }

    class Consumer
    {
        ConsoleColor myColor;
        int sum = 0;
        public Consumer(ConsoleColor cl)
        {
            this.myColor = cl;
        }

        public void DoConsume()
        {
            Supervisor.aConsumerStarts();
            bool keep = true;
            while (keep)
            {
                try
                {
                    int x = Supervisor.Consume();
                    Console.ForegroundColor = myColor;
                    Console.WriteLine(x);
                    sum++;
                }
                catch (Exception e)
                {
                    keep = false;
                    Console.WriteLine("The number: {0}", sum);
                }
            }
            Supervisor.aConsumerStops();
        }
    }

    class Supervisor
    {
        static List<int> buffer = new List<int>();
        static int maxSize = 50;
        static int numberOfProducers = 0;
        static int numberOfConsumers = 0;
        static bool isProducersStopped = false;
        static bool isConsumersStopped = false;

        public static void aProducerStarts()
        {
            lock (typeof(Supervisor))
            {
                numberOfProducers++;
            }
        }

        public static void aProducerStops()
        {
            lock (typeof(Supervisor))
            {
                numberOfProducers--;

                if (numberOfProducers == 0)
                    isProducersStopped = true;
            }
        }

        public static void Produce(int num)
        {
            lock (buffer)
            {
                while (buffer.Count >= maxSize)
                    Monitor.Wait(buffer);
                buffer.Add(num);
                Monitor.PulseAll(buffer);
            }
        }


        public static void aConsumerStarts()
        {
            lock (typeof(Supervisor))
            {
                numberOfConsumers++;
            }
        }

        public static void aConsumerStops()
        {
            lock (typeof(Supervisor))
            {
                numberOfConsumers--;

                if (numberOfConsumers == 0)
                    isConsumersStopped = true;
            }
        }

        public static int Consume()
        {
            int x = 0;
            lock (buffer)
            {
                while (buffer.Count <= 0)
                    if (isProducersStopped)
                        throw new Exception("No producers");
                    else
                        Monitor.Wait(buffer);
                x = buffer[0];
                buffer.RemoveAt(0);
                Monitor.PulseAll(buffer);
            }

            return x;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Producer p1 = new Producer(2, 10000);
            Producer p2 = new Producer(10001, 20000);
            Producer p3 = new Producer(20001, 30000);
            Producer p4 = new Producer(30001, 40000);

            Consumer c1 = new Consumer(ConsoleColor.Yellow);
            Consumer c2 = new Consumer(ConsoleColor.Blue);

            Thread t1 = new Thread(p1.DoWork);
            Thread t2 = new Thread(p2.DoWork);
            Thread t3 = new Thread(p3.DoWork);
            Thread t4 = new Thread(p4.DoWork);

            Thread t5 = new Thread(c1.DoConsume);
            Thread t6 = new Thread(c2.DoConsume);

            t1.Start(); t2.Start(); t3.Start(); t4.Start(); t5.Start(); t6.Start();
            t1.Join(); t2.Join(); t3.Join(); t4.Join(); t5.Join(); t6.Join();

            Console.ReadKey();
        }
    }
}
