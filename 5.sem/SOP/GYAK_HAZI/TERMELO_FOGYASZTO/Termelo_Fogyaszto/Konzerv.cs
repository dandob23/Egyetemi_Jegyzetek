using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termelo_Fogyaszto
{
    internal class Konzerv
    {
        public string Tipus { get; set; }
        public double Tomeg { get; set; }

        public Konzerv(string tipus, double tomeg)
        {
            this.Tipus = tipus;

            this.Tomeg = tomeg;
        }
    }
}
