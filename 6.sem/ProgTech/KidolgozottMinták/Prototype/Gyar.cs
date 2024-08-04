using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Gyar
    {
        public Gépkocsi[] sorozatgyartas(Gépkocsi g, string sz, int db)
        {
            Gépkocsi[] temp = new Gépkocsi[db];
            for (int i = 0; i < db; i++)
            {
                temp[i] = (Gépkocsi)g.Clone();
                temp[i].Szin = sz;
            }
            return temp;
        }

    }
}
