using mestintZHA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestintZHA.StateRepresentations.KnightsTour
{
    public class KnightsTourOperator : Operator
    {
        public int XDirection { get; set; }
        public int YDirection { get; set; }

        public KnightsTourOperator(int xDirection, int yDirection)
        {
            XDirection = xDirection;
            YDirection = yDirection;
        }


        public State Apply(State state)
        {
            if (state is null || !(state is KnightsTourState)) throw new Exception("Not Horse State");

            KnightsTourState newState = state.Clone() as KnightsTourState;

            newState.X += XDirection;
            newState.Y += YDirection;
            newState.Table[newState.X, newState.Y] = 1;
            return newState;
        }

        public bool IsApplicable(State state)
        {
            if (state is null || !(state is KnightsTourState)) return false;

            KnightsTourState horseState = state as KnightsTourState;

            int x = Math.Abs(XDirection);
            int y = Math.Abs(YDirection);

            if ((x == 2 && y == 1) || (x == 1 && y == 2))
            {
                int newX = horseState.X + XDirection;
                int newY = horseState.Y + YDirection;

                return newX >= 0 && newX < KnightsTourState.XLength &&
                       newY >= 0 && newY < KnightsTourState.YLength &&
                       horseState.Table[newX, newY] != 1;
            }

            return false;
        }
    }
}
