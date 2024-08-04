using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak.Interfaces
{
    public interface State : ICloneable
    {
        int[] QueenPositions { get; } // Az egyes királynők pozícióit tároló tömb

        bool IsTargetState(); // Ellenőrzi, hogy az adott állapot célállapot-e (megoldást jelent-e)

        
    }

}
