using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopy
{
    internal class Address:ICloneable
    {
        public string City {  get; set; }
        public string Street { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Address[city='{City}'; street='{Street}']";
        }
    }
}
