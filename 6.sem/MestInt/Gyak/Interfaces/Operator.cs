using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak.Interfaces
{
    public interface Operator
    {
        bool IsApplicable(State state); // Ellenőrzi, hogy alkalmazható-e az operátor az adott állapoton
        State Apply(State state); // Az operátor alkalmazása az adott állapoton
    }


}
