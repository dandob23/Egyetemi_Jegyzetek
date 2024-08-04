using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    //concrete strategy
    class GyorsanRepul : RepulesiStrat
    {
        public override void Repul()
        {
            Console.WriteLine("Gyorsan repül.");
        }
    }
}
