using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes; // Need this or not?
using Xunit;

namespace XUnitTestProject_TicTacToe
{
    public class UnitTest1
    {

        /// <summary>
        /// Given a game board, test for winners
        /// </summary>
        /*
        [Fact]
        public void CanFindHorizontalWinner()
        {
            // Arrange
            Board board = new Board();

            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;

            // Act
            board.GameBoard[0, 0] = "X";
            board.GameBoard[0, 1] = "X";
            board.GameBoard[0, 2] = "X";

            // Assert
            bool answer = game.CheckForWinner(board);
            Assert.True(answer);
        }
        */

        // Test 2: Test there's a switch in players between turns

        // Test 3: Test to confirm that the position the player inputs correlates to the correct index of the array

        // One other "unique" test of your own

        //[Fact]
        //public void Test1()
        //{

        //}


    }
}
