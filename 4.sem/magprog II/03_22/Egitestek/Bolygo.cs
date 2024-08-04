using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitestek
{
    internal class Bolygo:Egitest
    {
        private const string POSTFIX = "-B";

        private static double MIN_KERINGESI_TAVOLSAG = 0.37;
        private static double MAX_KERINGESI_TAVOLSAG = 30.07;


        private BolygoOsztaly bolygoOsztaly;

        public BolygoOsztaly BolygoOsztaly
        {
            get { return this.bolygoOsztaly; }
            set
            {
                this.bolygoOsztaly = value;
            }

        }

        private double keringesiTavolsag;
        public double KeringesiTavolsag
        {
            get { return this.keringesiTavolsag; }
            set
            {
                if (value<MIN_KERINGESI_TAVOLSAG)
                {
                    throw new Exception("A keringesi tavolsag erteke tul kicsi");
                }
                if (value>MAX_KERINGESI_TAVOLSAG)
                {
                    throw new Exception("A keringedsi tavolsag erteke tul nagy!");
                }
                this.keringesiTavolsag = value;
            }
        }

        public Bolygo(string nev, int eletkor, BolygoOsztaly osztaly, double keringesiTavolsag) : base(nev, eletkor)
        {
            this.Azonosito += POSTFIX;

            this.BolygoOsztaly = bolygoOsztaly;
            this.KeringesiTavolsag = keringesiTavolsag;
        }

        public Bolygo(string nev,int eletkor):this(nev,eletkor,BolygoOsztaly.NemIsmert, MIN_KERINGESI_TAVOLSAG)
        {

        }
    }
}
