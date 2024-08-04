using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Teherauto:Gépkocsi
    {
        private double teherbiras;
        public double Teherbiras
        {
            get { return teherbiras; }
            set { teherbiras = value; }
        }
        public Teherauto(string t, int u, double tm, double teherbiras)
            : base(t, u, tm) { this.teherbiras = teherbiras; }
        
        public override string ToString()
        {
            return base.ToString() + " " + Teherbiras;
        }

    }
}
