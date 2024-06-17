using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    class NormalHapogas : HapogasiStrat
    {
        public override void Hapog()
        {
            Console.WriteLine("Hagyományos módon hápog");
        }
    }
}
