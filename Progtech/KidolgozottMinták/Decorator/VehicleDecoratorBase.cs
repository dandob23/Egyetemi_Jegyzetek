using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class VehicleDecoratorBase : VehicleBase //Decorator osztály
    {
        protected VehicleBase vehicle; //HAS-A kapcsolat

        public VehicleDecoratorBase(VehicleBase vehicle)
        {
            this.vehicle = vehicle;
        }

        public override string Make
        {
            get { return vehicle.Make; }
        }

        public override string Model
        {
            get { return vehicle.Model; }
        }

        public override double HirePrice
        {
            get { return vehicle.HirePrice; }
        }

        public override int HireLaps
        {
            get { return vehicle.HireLaps; }
        }
    }
}
