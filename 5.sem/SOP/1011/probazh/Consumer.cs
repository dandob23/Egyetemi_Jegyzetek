using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probazh
{
    internal class Consumer
    {
        static uint ID;
        uint id;

        public Consumer()
        {
            id = ID++;
        }

        public void Work()
        {
            Product product = null;
            while (Controller.products.Count > 0 || Controller.areProducersWorking)
            {
                if (Controller.TryConsumeSlow(this, out product))
                {
                    Console.WriteLine($"SlowConsumer({this}) has consumed {product}...");
                    product = null;
                }
                if (Controller.TryConsumeFast(this, out product))
                {
                    Console.WriteLine($"FastConsumer has consumed {product}...");
                    product = null;
                }
            }
            Console.WriteLine($"FastConsumer({this}) has finished.");
        }

        public override string ToString()
        {
            return $"Consumer {id}";
        }
    }
}
