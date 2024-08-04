using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1004
{
    internal class Core
    {
        static uint ID;
        uint id;
        Random rnd = new Random();
        double min = 3;
        double max = 10;

        public Core() 
        {
            this.id = ID++;
        }

        public void IncreaseProduction()
        {
            min += 20;
            max += 50;
        }

        public void DecreaseProduction()
        {
            double x = rnd.Next(1, 4);

            if(min - x > 1)
            {
                min -= x;
            }
            if (max - x > 1)
            {
                max -= x;
            }
        }

        public void Work()
        {
            while (true)
            {
                Controller.ProducePower(this, rnd.Next((int)min, (int)max));
                Thread.Sleep(1000);
            }
        }
    }
}
