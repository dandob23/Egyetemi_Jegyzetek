using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetSzemelyesJatekok.Interfaces
{
    public abstract class State : ICloneable
    {
        public char CurrentPlayer { get; set; }

        public abstract Status GetStatus();

        public abstract int GetHeuristic(char player);

        public abstract object Clone();
    }
}
