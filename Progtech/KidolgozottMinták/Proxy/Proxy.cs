using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // The 'Proxy' osztály
    // Tartalmaz egy referenciát a tényleges objektumra, hogy el tudja azt érni. 
    // Szabályozza a hozzáférést a tényleges objektumhoz, feladata lehet a tényleges 
    // objektum létrehozása és törlése is.

    class Proxy :Tárgy
    {
        private ValódiTárgy valódiTárgy;
        public override void Kérés()
        {
            if (valódiTárgy == null) { valódiTárgy = new ValódiTárgy(); }
            valódiTárgy.Kérés();
        }

    }
}
