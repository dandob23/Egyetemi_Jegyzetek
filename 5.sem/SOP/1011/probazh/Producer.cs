using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace probazh
{
    internal class Producer
    {
        static uint ID;
        uint id;

        int amountToProduce;
        int productCount;
        bool isWorking;

        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Producer(int amountToProduce)
        {
            id = ID++;
            this.amountToProduce = amountToProduce;
            IsWorking = false;
        }

        public void Work()
        {
            Product product = null;
            while (productCount < amountToProduce)
            {
                if (product == null)
                {
                    product = new Product();
                }
                if (Controller.TryProduceFast(this, product))
                {
                    productCount++;
                    Console.WriteLine($"FastProducer({this}) has produced {product}");
                    product = null;
                    Thread.Sleep(TimeSpan.FromSeconds(2)); // Adjust the waiting time as needed
                }
                if (productCount < amountToProduce && Controller.TryProduceSlow(this, product))
                {
                    productCount++;
                    Console.WriteLine($"SlowProducer({this}) has produced {product}");
                    product = null;
                    Thread.Sleep(TimeSpan.FromSeconds(5)); // Adjust the waiting time as needed
                }
            }
            isWorking = false;
            Controller.CheckProducerWorkingState();
        }

        public override string ToString()
        {
            return $"Producer {id}";
        }
    }
}
