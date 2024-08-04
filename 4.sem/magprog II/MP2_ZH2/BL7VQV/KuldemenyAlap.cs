using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal abstract class KuldemenyAlap:ICloneable,IComparable
    {
        private static int ID = 1;

        protected KuldemenyAlap(int szelesseg, int magassag, int melyseg, double tomeg, string orszagKod, string varos)
        {
            this.id = ID++;
            Szelesseg = szelesseg;
            Magassag = magassag;
            Melyseg = melyseg;
            Tomeg = tomeg;
            Cim = new Cim(orszagKod, varos);
        }

        private int id;
        public string Id { get { return "EP" + id.ToString().PadLeft(4, '0'); } }
        public int Szelesseg { get; set; }
        public int Magassag { get; set; }
        public int Melyseg { get; set; }

        private double tomeg;
        public double Tomeg 
        {
            get
            {
                this.tomeg = Tomeg;

                if (tomeg<0||tomeg<1)
                {
                    throw new TomegAlacsonyException((int)tomeg);
                }
                else
                {
                    return Tomeg;
                }
            }
            set
            {
                Tomeg = value;
            }
        }

        public abstract double TerfogatSuly { get; }

        public double VeglegesTomeg 
        {
            get { return Math.Max(Tomeg, TerfogatSuly); } 
        }

         
        public bool Terfogatsulyos 
        {
            get { return TerfogatSuly > Tomeg; } 
        }

        public abstract int KalkulaltAr();

        public override bool Equals(object obj)
        {
            if (obj is KuldemenyAlap)
            {
                KuldemenyAlap kuldemeny = (KuldemenyAlap)obj;
                return this.Id == kuldemeny.Id;
            }
            else
            {
                return false;
            }
        }

        public abstract object Clone();

         public int CompareTo(object obj)
        {
            if (obj is KuldemenyAlap)
            {
                KuldemenyAlap kuldemeny = (KuldemenyAlap)obj;
                return this.VeglegesTomeg.CompareTo(kuldemeny.VeglegesTomeg);
            }
            else
            {
                throw new ArgumentException("A paraméter nem KuldemenyAlap típusú!");
            }
        }
         
        public Cim Cim { get; set; }

        public double Terfogat { get { return Szelesseg * Magassag * Melyseg; } }

        public override string ToString()
        {
            return String.Format("{0}: {1}, {2} x {3} x {4}, {5:.00} kg {6} Ft{7}",
                Id,
                Cim,
                Szelesseg, Magassag, Melyseg,
                VeglegesTomeg,
                KalkulaltAr(),
                Terfogatsulyos ? " (TS)" : "");
        }
    }
}
