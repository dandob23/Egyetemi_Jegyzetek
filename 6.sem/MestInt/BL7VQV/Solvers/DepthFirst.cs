using mestintZHA.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestintZHA.Solvers
{
    public class DepthFirst : Solver
    {
        public Stack<Node> OpenNodes { get; set; }
        public List<Node> ClosedNodes { get; set; }
        public Node CurrentNode { get; set; }
        public Node Path { get; set; }
        public int ExploredNodes { get; set; }
        public int DuplicatedNodes { get; set; }


        public DepthFirst(OperatorGenerator operatorGenerator, State startingState) : base(operatorGenerator)
        {
            OpenNodes = new Stack<Node>();
            ClosedNodes = new List<Node>();
            OpenNodes.Push(new Node(startingState));

        }

        public Operator SelectOperator()
        {
            int index = CurrentNode.OperatorIndex++;
            while (index<OperatorGenerator.Operators.Count)
            {
                if (OperatorGenerator.Operators[index].IsApplicable(CurrentNode.State))
                {
                    return OperatorGenerator.Operators[index];
                }
                index = CurrentNode.OperatorIndex++;
            }
            return null;
            
        }

        public override void Solve()
        {
            Path = null;
            ExploredNodes = 0;
            DuplicatedNodes = 0;


            while (OpenNodes.Count > 0)
            {
                CurrentNode = OpenNodes.Pop();
                ExploredNodes++;

                if (CurrentNode.IsTargetNode())
                {
                    Path = CurrentNode;
                    break;
                }

                ClosedNodes.Add(CurrentNode);

                Operator selectedOperator = SelectOperator();

                while (selectedOperator != null)
                {
                    State newState = selectedOperator.Apply(CurrentNode.State);
                    Node newNode = new Node(newState, CurrentNode);

                    if (ClosedNodes.Contains(newNode))
                    {
                        DuplicatedNodes++;
                    }
                    else if (!OpenNodes.Contains(newNode))
                    {
                        OpenNodes.Push(newNode);
                    }

                    selectedOperator = SelectOperator();
                }
            }

            if (Path==null)
            {
                Console.WriteLine("No solution found...");
            }
            else
            {
                Console.WriteLine("Solution found...");
                Console.WriteLine("------------------------------------");

                Console.Write("\nSolution: \t");
                Console.WriteLine(Path);

                Console.Write("\nSolution at depth: \t");
                Console.WriteLine(Path.Depth);

                Console.Write("\nExplored nodes: \t");
                Console.WriteLine(ExploredNodes);

                Console.Write("\nDuplicated nodes: \t");
                Console.WriteLine(DuplicatedNodes);
            }
        }
    }
}
