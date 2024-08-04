using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Kuldemeny:KuldemenyAlap,ICloneable,IBiztositas
    {
        private static double TERFOGATSULY_EGYUTTHATO = 139.0;
        private static int TERFOGATSULY_ALAP_AR = 2850;
        private static int ALAP_AR = 1950;
        private static int AR_KILOGRAMMONKENT = 950;
        private static int EUN_KIVULI_FELAR = 1350;

        public Kuldemeny(int szelesseg, int magassag, int melyseg, double tomeg,
            string orszagKod, string varos, BiztositasTipus biztositasTipus):base(KuldemenyAlap())
        {
            this.Szelesseg = szelesseg;
            this.Magassag = magassag;
            this.Melyseg = melyseg;
            this.Tomeg = tomeg;
            this.Cim = new Cim(orszagKod, varos);
            this.BiztositasTipus = biztositasTipus;

            if (BiztositasTipus == null)
            {
                this.BiztositasTipus = new BiztositasTipus("Nincs");
            }
        }

        public override double TerfogatSuly
        {
            get
            {
                return (Szelesseg * Magassag * Melyseg) / TERFOGATSULY_EGYUTTHATO;
            } 
        }
        public BiztositasTipus BiztositasTipus { get; set; }

        public int Biztositas(int ertek)
        {
            if (BiztositasTipus == BiztositasTipus.Alap)
            {
                return (int)(ertek * 0.1);
            }
            else if (BiztositasTipus == BiztositasTipus.Extra)
            {
                return (int)(ertek * 0.2);
            }
            else
            {
                return 0;
            }
        }

        public override object Clone()
        {    

            throw new NotImplementedException();
        }

        public override int KalkulaltAr()
        {
            int ar = ALAP_AR + (int)VeglegesTomeg * AR_KILOGRAMMONKENT;
            if (Cim.OrszagKod != "EU")
            {
                ar += EUN_KIVULI_FELAR;
            }
            return ar;
        }

        public override string ToString()
        {
            return base.ToString() +
                (BiztositasTipus != BiztositasTipus.Nincs ? " (Bizt.: " + BiztositasTipus.ToString() + ")" : "");
        }
    }
}
