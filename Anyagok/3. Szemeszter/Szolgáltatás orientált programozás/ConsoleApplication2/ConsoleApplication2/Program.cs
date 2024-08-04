/*
4. Jövő hétre:

Készítsünk többszálú, termelő-fogyasztó modellű megoldást az alábbiakra:

-  A console ablak fejléce mutassa, hogy hány elem van a pufferben. :-)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Producer
    {
        int oszto = 0; int darab = 0; int k = 1;
        Random rnd = new Random();

        public Producer(int oszt, int db)
        {
            this.oszto = oszt; this.darab = db;
        }

        public void DoGeneral()
        {

            Supervisor.aProducerStarts();
            for (int i = 0; i < darab; i++)
            {
                k = rnd.Next(10000, 90001);

                while (!Oszthato(k, oszto))
                    k = rnd.Next(10000, 90001);

                Supervisor.Produce(k);
                Console.WriteLine(k + " +");

            }
            Supervisor.aProducerStops();
        }

        bool Oszthato(int num, int oszto)
        {
            bool oszt = true;

            if (num % oszto != 0)
                oszt = false;

            return oszt;
        }

    }

    class Consumer
    {
        ConsoleColor myColor;
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
                    Console.WriteLine(x + " -");
                }
                catch (Exception)
                {
                    keep = false;
                }
            }
            Supervisor.aConsumerStops();
        }


    }

    class Supervisor
    {
        static List<int> buffer = new List<int>();
        static int maxSize = 100;
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
            Producer p1 = new Producer(3, 200);
            Producer p2 = new Producer(5, 100);
            Producer p3 = new Producer(7, 200);

            Consumer c1 = new Consumer(ConsoleColor.Red);
            Consumer c2 = new Consumer(ConsoleColor.White);
            Consumer c3 = new Consumer(ConsoleColor.Green);

            Thread t1 = new Thread(p1.DoGeneral);
            Thread t2 = new Thread(p2.DoGeneral);
            Thread t3 = new Thread(p3.DoGeneral);

            Thread t4 = new Thread(c1.DoConsume);
            Thread t5 = new Thread(c2.DoConsume);
            Thread t6 = new Thread(c3.DoConsume);

            t1.Start(); t2.Start(); t3.Start(); t4.Start(); t5.Start(); t6.Start();
            t1.Join(); t2.Join(); t3.Join(); t4.Join(); t5.Join(); t6.Join();

            Console.ReadKey();
        }
    }
}
