using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Hanoi
{
    internal abstract class Asolver
    {
        protected List<Operator> Operators = new List<Operator>();

        protected State StartState;
        public Asolver(int numberOfDiscs)
        {
            StartState = new State(numberOfDiscs);
        }

        private void GenerateOperators()
        {
            for (int from = 0; from < 3; from++)
            {
                for (int to = 0; to < 3; to++)
                {
                    if (from != to)
                    {
                        Operators.Add(new Operator(from, to));
                    }
                }
            }
        }

        protected abstract Operator SelectOperator();
        public abstract void Solve();
    }
}
