using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class VehicleBase //alap osztály
    {
        public abstract string Make { get; }
        public abstract string Model { get; }
        public abstract double HirePrice { get; }
        public abstract int HireLaps { get; }
    }
}
