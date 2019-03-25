using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// Outputs board to console and is called at start of game, at each new turn in game, and at end of game
        /// </summary>
		public void DisplayBoard()
		{
            //TODO: Output the board to the console
            for (int x = 0; x < GameBoard.GetLength(0); x++)
            {
                for (int y = 0; y < GameBoard.GetLength(1); y++)
                {
                    Console.Write($"|{GameBoard[x, y]}|");
                }
                Console.WriteLine();
            }
        }
	}
}
