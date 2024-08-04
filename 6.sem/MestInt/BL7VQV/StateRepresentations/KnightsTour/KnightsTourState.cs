using mestintZHA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestintZHA.StateRepresentations.KnightsTour
{
    public class KnightsTourState : State
    {
        public static int XLength = 5;
        public static int YLength = 4;


        public int[,] Table { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public KnightsTourState()
        {
            Table = new int[XLength, YLength];
            Table[0, 0] = 1;
            X = 0;
            Y = 0;
        }


        public object Clone()
        {
            KnightsTourState clone = new KnightsTourState();

            clone.Table = Table.Clone() as int[,];
            clone.X = X;
            clone.Y = Y;

            return clone;
        }

        public bool IsTargetState()
        {
            foreach (var item in Table)
            {
                if (item == 0) return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is KnightsTourState)) return false;

            KnightsTourState horseState = obj as KnightsTourState;

            if (horseState.X != X || horseState.Y != Y) return false;

            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    if (Table[i, j] != horseState.Table[i, j]) return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Table.GetLength(0); i++)
            {

                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    if (i == X && j == Y)
                    {
                        sb.Append(" H ");
                    }
                    else
                    {
                        sb.Append($" {Table[i, j]} ");
                    }
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
