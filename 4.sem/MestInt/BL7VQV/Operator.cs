using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    public class Operator
    {
        private int index;

        public Operator(int index)
        {
            this.index = index;
        }

        public State Apply(State state)
        {
            State newState = new State(state);

            int row = index / 9;
            int col = index % 9;

            if (newState.Values[row, col] == '-')
            {
                newState.Values[row, col] = '3';
            }

            return newState;
        }

        internal bool Elofeltetel(State aktualisAllapot)
        {
            throw new NotImplementedException();
        }
    }
}
