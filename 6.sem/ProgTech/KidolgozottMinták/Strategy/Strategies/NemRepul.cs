using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    class NemRepul : RepulesiStrat
    {
        public override void Repul()
        {
            Console.WriteLine("Nem repül.");
        }
    }
}
