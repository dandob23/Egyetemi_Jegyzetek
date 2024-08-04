using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Kacsa : AKacsa
    {
        HapogasiStrat hs; //objektum-összetétel
        RepulesiStrat rs;

        public Kacsa(HapogasiStrat hs, RepulesiStrat rs)
        {
            this.hs = hs; //felelősség beinjektálása
            this.rs = rs;
        }
        public override void Hapog()
        {
            hs.Hapog(); //delegálás (felelősség átadás)
        }

        public override void Repul()
        {
            rs.Repul(); //delegálás
        }
    }
}
