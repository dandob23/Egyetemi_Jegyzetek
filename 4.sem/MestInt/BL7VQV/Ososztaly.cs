using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    public abstract class Ososztaly
    {
        protected State kezdoAllapot;
        protected State celAllapot;
        protected List<Operator> Operator = new List<Operator>();

        public Ososztaly(State kezdo, State cel)
        {
            kezdoAllapot = kezdo;
            celAllapot = cel;
            OperatorokLetrehozasa();
        }



        protected abstract void OperatorokLetrehozasa();

        public abstract void Kereses();

        internal void Melysegi(int maxDepth)
        {
            throw new NotImplementedException();
        }
    }
}
