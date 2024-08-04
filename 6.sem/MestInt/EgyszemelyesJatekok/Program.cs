using _02_EgyszemelyesJatekok.Solvers;
using EgyszemelyesJatekok.StateRepresentations.Hanoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyszemelyesJatekok.Interfaces;

namespace EgyszemelyesJatekok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solver solver = new BackTrackWithBranchLimit(
                new HanoiOperatorGenerator(),
                new HanoiState(), 50
                );

            solver.Solve();

            Console.ReadLine();
        }
    }
}
