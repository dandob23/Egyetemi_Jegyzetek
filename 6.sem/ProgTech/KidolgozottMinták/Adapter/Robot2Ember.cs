using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Robot2Ember : Ember
    {
        Robot robi;
        public Robot2Ember(Robot robi) { this.robi = robi; }
        public override string GetNév()
        {
            return robi.GetID();
        }
        public override int GetIQ()
        {
            return robi.GetMemory() / 1024; // 1GB memória = 1 IQ
        }

    }
}
