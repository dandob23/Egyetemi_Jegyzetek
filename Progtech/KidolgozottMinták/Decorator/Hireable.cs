using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Hireable: VehicleDecoratorBase //concrete decorator
    {
        public Hireable(VehicleBase vehicle) : base(vehicle) 
        {
        }

        public void Hire(string name) 
        {
            Console.WriteLine("{0} {1} típust kölcsönzött {2} {3}$-ért {4} körre...", Make, Model, name, HirePrice, HireLaps); 
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
