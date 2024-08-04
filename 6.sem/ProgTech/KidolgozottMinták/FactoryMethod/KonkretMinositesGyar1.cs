using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class KonkretMinositesGyar1 : MinositesGyar
    {
        public override Minosites Minosit() { return new A_Minosites(); }

    }
}
