using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SpecialOffer : VehicleDecoratorBase //concrete decorator
    {
        public SpecialOffer(VehicleBase vehicle) : base(vehicle)
        {
        }

        public int Discount { get; set; } 
        public int ExtraLaps { get; set; }

        public override double HirePrice //kölcsönzési ár kiszámítása
        {
            get
            {
                double price = base.HirePrice; //ősosztályból örökölt érték
                int discount = 100 - Discount; 
                return Math.Round((price * discount) / 100, 2); //kerekítés 2 tizedesre
            }
        }

        public override int HireLaps
        {
            get
            {
                return base.HireLaps + ExtraLaps;
            }
        }
    }
}
