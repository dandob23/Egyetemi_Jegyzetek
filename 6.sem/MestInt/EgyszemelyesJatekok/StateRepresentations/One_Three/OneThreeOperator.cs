using EgyszemelyesJatekok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszemelyesJatekok.StateRepresentations.One_Three
{
    public class OneThreeOperator : Operator
    {

        public int XDirection { get; set; }
        public int YDirection { get; set; }

        public OneThreeOperator(int xDirection, int yDirection)
        {
            XDirection = xDirection;
            YDirection = yDirection;
        }


        public State Apply(State state)
        {
            throw new NotImplementedException();
        }

        public bool IsApplicable(State state)
        {
            if (state == null || !(state is OneThreeState)) return false;



            OneThreeState gameState = state as OneThreeState;

            if (XDirection == 0 && YDirection == 0) return false;

            int newX = gameState.X + (XDirection * OneThreeState.Table[gameState.X, gameState.Y]);
            int newY = gameState.Y + (XDirection * OneThreeState.Table[gameState.X, gameState.Y]);

            return newX >=0 && newX <=6 && newY >=0 && newY <=6;
        }
    }
}
