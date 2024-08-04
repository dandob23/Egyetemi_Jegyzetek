using EgyszemelyesJatekok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszemelyesJatekok.StateRepresentations.Hanoi
{
    internal class HanoiOperatorGenerator : OperatorGenerator
    {
        public List<Operator> Operators { get; }

        public HanoiOperatorGenerator()
        {
            Operators = new List<Operator>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        Operators.Add(new HanoiOperator(i, j));
                    }
                }
            }
        }
    }
}
