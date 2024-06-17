using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Gépkocsi : ICloneable
    {
        private string tipus;
        public string Tipus
        {
            get { return tipus; }
            set { tipus = value; }
        }
        private int utasokSzama;
        public int UtasokSzama
        {
            get { return utasokSzama; }
            set { utasokSzama = value; }
        }
        private double tankMeret;
        public double TankMeret
        {
            get { return tankMeret; }
            set { tankMeret = value; }
        }
        private string szin;
        public string Szin
        {
            get { return szin; }
            set { szin = value; }
        }
        public Gépkocsi(string tipus, int utasokSzama, double tankMeret)
        {
            this.tipus = tipus;
            this.utasokSzama = utasokSzama;
            this.tankMeret = tankMeret;
        }
        public object Clone() { return this.MemberwiseClone(); }

        public override string ToString()
        {
            return tipus + " " + utasokSzama + " " + tankMeret + " " + szin;
        }

    }
}
