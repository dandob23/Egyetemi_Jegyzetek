using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // Közös interfész a Tárgy és a Proxi számára, ezáltal tud a minta működni.
    abstract class Tárgy
    {
        public abstract void Kérés();   
    }
}
