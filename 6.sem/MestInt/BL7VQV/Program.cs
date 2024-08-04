using mestintZHA.Interfaces;
using mestintZHA.Solvers;
using mestintZHA.StateRepresentations.KnightsTour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestintZHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solver solver = new DepthFirst(
                new KnightsTourOperatorGenerator(),
                new KnightsTourState()
                );

            solver.Solve();

            Console.ReadLine();
        }
    }
}
