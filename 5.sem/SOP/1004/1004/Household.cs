using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1004
{
    internal class Household
    {
        static uint ID;
        uint id;

        Random rnd = new Random();

        public Household()
        {
            this.id = ID++;
        }

        public void Work()
        {
            while (true)
            {
                Controller.ConsumePower(rnd.Next(26, 33) / 1000);
                Thread.Sleep(1000);
            }
        }

    }
}
