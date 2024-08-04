using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak.Interfaces
{
    public abstract class Solver
    {
        protected OperatorGenerator OperatorGenerator { get; } // Operátor generátor referenciája

        public Solver(OperatorGenerator operatorGenerator, State startingState)
        {
            OperatorGenerator = operatorGenerator;
        }

        public override Node Solve(Node initialState)
        {
            StartingState = initialState.State;
            Node path = BacktrackWithBranchLimit(new Node(StartingState), DepthLimit);
            if (path != null)
            {
                Console.WriteLine("Solution found!");
                Console.WriteLine(path);
            }
            else
            {
                Console.WriteLine("Solution not found!");
            }
            return path;
        }



    }
}
