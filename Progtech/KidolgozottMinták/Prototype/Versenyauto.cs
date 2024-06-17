using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Versenyauto : Gépkocsi
    {
        private int vegsebesseg;
        public int Vegsebesseg
        {
            get { return vegsebesseg; }
            set { vegsebesseg = value; }
        }
        public Versenyauto(string t, int u, double tm, int vegsebesseg) :
            base(t, u, tm)
        { this.vegsebesseg = vegsebesseg; }
        
        public override string ToString()
        {
            return base.ToString() + " " + vegsebesseg;
        }

    }
}
