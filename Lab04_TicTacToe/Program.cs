using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();

            Console.ReadLine();
        }

        static void PlayGame()
        {
            // TODO: Setup your game here. Create an introduction. 
            // Create your players, and instantiate your Game class. 
            // Output to the console the winner

            Console.WriteLine("Let's play tic tac toe!");
            Console.WriteLine(" ");

            Console.WriteLine("Player 1, enter your name.");
            string p1 = Console.ReadLine();
            Console.WriteLine(" ");

            // Create player 1 object
            Player player1 = new Player
            {
                Name = p1,
                Marker = "X",
                IsTurn = true
            };

            Console.WriteLine("Player 2, enter your name");
            string p2 = Console.ReadLine();

            // Create player 2 object
            Player player2 = new Player
            {
                Name = p1,
                Marker = "O",
                IsTurn = false
            };
            Console.Clear();
            Console.WriteLine("Let's play!");
            Game game = new Game(player1, player2);
            Player winner = game.Play();
            Console.WriteLine($"And the winner is...{winner}!");
        }
    }
}
