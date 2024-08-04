using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy_Prototype
{
    internal class Address:IPrototype<Address>
    {
        public string City { get; set; }
        public string Street { get; set; }

        public Address DeepCopy()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Address[city='{City}'; street='{Street}']";
        }
    }
}
