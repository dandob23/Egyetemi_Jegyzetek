using mestintZHA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestintZHA.StateRepresentations.KnightsTour
{
    public class KnightsTourOperatorGenerator : OperatorGenerator
    {
        public List<Operator> Operators { get; }

        public KnightsTourOperatorGenerator()
        {
            Operators = new List<Operator>();

            for (int i = -2; i <= 2; i++)
            {
                for (int j = -2; j <= 2; j++)
                {
                    if (Math.Abs(i) != Math.Abs(j) && i != 0 && j != 0)
                    {
                        Operators.Add(new KnightsTourOperator(i, j));
                    }
                }
            }
        }
    }
}
