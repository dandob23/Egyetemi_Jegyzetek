using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CyberTruck : VehicleBase
    {
        public override string Make
        {
            get { return "Tesla"; }
        }

        public override string Model
        {
            get { return "CyberTruck"; }
        }

        public override double HirePrice
        {
            get { return 500; }
        }

        public override int HireLaps
        {
            get { return 10; }
        }
    }
}
