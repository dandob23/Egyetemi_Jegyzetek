using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004
{
    internal class PowerGrid
    {
        double mWh;
        double powerNeed;

        
        public PowerGrid()
        {
            mWh = 0;
            powerNeed = 0;
        }

        public double MWh { get => mWh; set => mWh = value; }
        public double PowerNeed { get => powerNeed; set => powerNeed = value; }

        public void AddPower(double mwh)
        {
            this.mWh += mwh;
            powerNeed -= mwh / 10;
        }

        public void GetPower(double mwh)
        {
            this.mWh -= mwh;
            powerNeed += mwh;
        }

        public bool HasEnoughPower(double mwh)
        {
            double x = this.mWh - mwh;
            if (x > 0)
            {
                return true;
            }
            else
            {
                if (powerNeed < 0)
                {
                    powerNeed = 0;
                }
                powerNeed -= x;
                return false;
            }
        }
    }
}
