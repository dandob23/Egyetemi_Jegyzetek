using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.CreateProducers(1, 50, WineType.CABERNET_FRANC_2018, 2, 1, 0.5);
            Controller.CreateProducers(1, 50, WineType.EGRI_CSILLAG_2022, 2, 1, 0.5);
            Controller.CreateConsumers(3,2);
            Controller.StartThreads();

            Console.ReadKey();

        }
    }
}
