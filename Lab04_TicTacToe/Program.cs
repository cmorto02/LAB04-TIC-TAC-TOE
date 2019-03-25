using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }
        static void PlayGame()
        {
            Console.WriteLine("Lets play Tic Tac Toe!");
            Console.WriteLine("Player 1, please enter your name:");
            string p1 = Console.ReadLine();
            Player player1 = new Player
            {
                Name = p1,
                Marker = "X",
                IsTurn = true
            };
            Console.WriteLine("Player 2, please enter your name:");
            string p2 = Console.ReadLine();
            Player player2 = new Player
            {
                Name = p2,
                Marker = "O",
                IsTurn = false
            };
            Console.Clear();
            Console.WriteLine("Lets start!");
            Game game = new Game(player1, player2);
            Player winner = game.Play();
            if(!(winner is null))
            {
                Console.WriteLine($"{winner.Name} Wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
