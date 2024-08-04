using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class KonkretMinositesGyar2 : MinositesGyar
    {
        public override Minosites Minosit() { return new B_Minosites(); }

    }
}
