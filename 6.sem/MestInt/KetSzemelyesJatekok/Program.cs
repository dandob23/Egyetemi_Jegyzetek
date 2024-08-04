using KetSzemelyesJatekok.StateRepresentation.TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetSzemelyesJatekok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToePlayer player = new TicTacToePlayer();

            player.Play();
        }
    }
}
