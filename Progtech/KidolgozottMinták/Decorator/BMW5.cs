using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BMW5 : VehicleBase
    {
        public override string Make
        {
            get { return "BMW"; }
        }

        public override string Model
        {
            get { return "5"; }
        }

        public override double HirePrice
        {
            get { return 200; }
        }

        public override int HireLaps
        {
            get { return 5; }
        }
    }
}
