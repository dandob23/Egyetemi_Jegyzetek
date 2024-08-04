﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL7VQV;

class Program
{
    static void Main(string[] args)
    {
        int[,] sudoku = {
                { 5, 6, 0, 0, 0, 2, 7, 0, 8 },
                { 0, 4, 0, 7, 9, 0, 0, 5, 0 },
                { 7, 0, 0, 3, 0, 0, 4, 2, 0 },
                { 0, 0, 4, 8, 7, 0, 3, 2, 1 },
                { 0, 3, 0, 0, 0, 0, 0, 0, 8 },
                { 0, 7, 8, 1, 2, 0, 0, 4, 0 },
                { 1, 3, 0, 7, 0, 0, 2, 4, 0 },
                { 9, 0, 0, 6, 0, 4, 0, 0, 0 },
                { 2, 6, 0, 0, 0, 3, 0, 9, 7 }
            };

        int maxDepth = 42;

        Ososztaly sudokuSolver = new Ososztaly(sudoku);

        sudokuSolver.Melysegi(maxDepth);

        Console.ReadKey();

    }

}
