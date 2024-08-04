using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak.Interfaces
{
    public class Node
    {
        public int[] QueenPositions { get; } // Az egyes királynők pozícióit tároló tömb
        public int Depth { get; } // A csúcs mélysége a fa/gráfban
        public Node Parent { get; } // A szülő csúcs referenciája

        public Node(int[] queenPositions, Node parent = null)
        {
            QueenPositions = queenPositions;
            Parent = parent;

            if (parent == null)
                Depth = 0;
            else
                Depth = parent.Depth + 1;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Node)) return false;

            Node node = (Node)obj;

            // Az egyezőség vizsgálata az állapotok között
            for (int i = 0; i < QueenPositions.Length; i++)
            {
                if (QueenPositions[i] != node.QueenPositions[i])
                    return false;
            }
            return true;
        }

        public bool IsTargetNode()
        {
            // Ellenőrizzük, hogy az adott állapot célállapot-e (8 királynő mindenikének egyetlen sorban, oszlopban vagy átlósan sem ütköznie)
            for (int i = 0; i < QueenPositions.Length; i++)
            {
                for (int j = i + 1; j < QueenPositions.Length; j++)
                {
                    if (QueenPositions[i] == QueenPositions[j] || Math.Abs(QueenPositions[i] - QueenPositions[j]) == Math.Abs(i - j))
                        return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // Királynők pozícióinak kiírása
            for (int i = 0; i < QueenPositions.Length; i++)
            {
                for (int j = 0; j < QueenPositions.Length; j++)
                {
                    if (QueenPositions[j] == i)
                        sb.Append("Q ");
                    else
                        sb.Append(". ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }

}
