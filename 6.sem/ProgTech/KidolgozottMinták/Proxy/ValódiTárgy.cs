using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // valódi munka "tárgy"amit tenni akarunk
    // a valódi objektum, amit a proxy elrejt
    class ValódiTárgy : Tárgy
    {
        public override void Kérés()
        {
            Console.WriteLine("Meghívom a ValódiTárgy.Kérés-et()");
        }
    }
}
