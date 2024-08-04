using Gyak.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak.Solvers
{
    public class BackTrackWithBranchLimit : Solver
    {
        public int DepthLimit { get; } // A mélységi limit
        public State StartingState { get; set; }

        public BackTrackWithBranchLimit(OperatorGenerator operatorGenerator, State startingState, int depthLimit)
     : base(operatorGenerator, startingState)
        {
            DepthLimit = depthLimit;
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

        private Node BacktrackWithBranchLimit(Node currentNode, int depthLimit)
        {
            if (currentNode.Depth >= depthLimit)
                return null;

            if (currentNode.IsTargetNode())
                return currentNode;

            foreach (Operator op in OperatorGenerator.GenerateOperators(currentNode))
            {
                if (op.IsApplicable(currentNode))
                {
                    Node childNode = new Node(op.Apply(currentNode.State), currentNode);
                    Node result = BacktrackWithBranchLimit(childNode, depthLimit);
                    if (result != null)
                        return result;
                }
            }

            return null;
        }
    }


}
