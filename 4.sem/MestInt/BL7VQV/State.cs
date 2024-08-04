using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    public class State
    {
        public int[,] board = new int[9, 9];
        private State state;

        public State(string input)
        {
            string[] rows = input.Split('\n'); 
            for (int i = 0; i < 9; i++)
            {
                string[] cols = rows[i].Split(';'); 
                for (int j = 0; j < 9; j++)
                {
                    if (cols[j] == "-") 
                    {
                        board[i, j] = 0;
                    }
                    else
                    {
                        board[i, j] = int.Parse(cols[j]);
                    }
                }
            }
        }

        public State(State state)
        {
            this.state = state;
        }

        public State Clone()
        {
            return new State((int[])sudoku.Clone());
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            State other = (State)obj;
            return sudoku.SequenceEqual(other.sudoku);
        }

        //--------------------------------------------------------------------//
        public bool IsGoalState()
        {
            
            for (int i = 0; i < 9; i++)
            {
                bool[] used = new bool[10]; 
                for (int j = 0; j < 9; j++)
                {
                    int num = board[i, j];
                    if (num == 0 || used[num])
                    {
                        return false; 
                    }
                    used[num] = true;
                }
            }
            //--------------------------------------------------------------------//

            for (int j = 0; j < 9; j++)
            {
                bool[] used = new bool[10]; 
                for (int i = 0; i < 9; i++)
                {
                    int num = board[i, j];
                    if (num == 0 || used[num])
                    {
                        return false; 
                    }
                    used[num] = true;
                }
            }
            //--------------------------------------------------------------------//

            for (int k = 0; k < 9; k++)
            {
                bool[] used = new bool[10]; 
                for (int i = (k / 3) * 3; i < (k / 3) * 3 + 3; i++)
                {
                    for (int j = (k % 3) * 3; j < (k % 3) * 3 + 3; j++)
                    {
                        int num = board[i, j];
                        if (num == 0 || used[num])
                        {
                            return false; 
                        }
                        used[num] = true;
                    }
                }
            }
            //--------------------------------------------------------------------//


            return true;
        }
    }

}
