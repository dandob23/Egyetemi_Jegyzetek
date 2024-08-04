using KetSzemelyesJatekok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KetSzemelyesJatekok.Solvers
{
    internal class HeuristicSolver:Solver
    {
        public HeuristicSolver(OperatorGenerator operatorGenerator): base(operatorGenerator)
        {

        }

        public override State NextMove(State state)
        {
            List<State> states = new List<State>();

            foreach ( Operator op in Operators)
            {
                if (op.IsApplicable(state))
                {
                    states.Add(op.Apply(state));
                }
            }

            char player = state.CurrentPlayer;

            states.Sort((x,y) => y.GetHeuristic(player).CompareTo(x.GetHeuristic(player)));

            return states[0];
        }
    }
}
