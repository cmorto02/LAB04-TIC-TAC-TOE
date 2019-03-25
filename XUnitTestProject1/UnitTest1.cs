using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ICanSeeAWinner()
        {
            Board board = new Board();

            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;

            // ACT
            board.GameBoard[0, 0] = "X";
            board.GameBoard[0, 1] = "X";
            board.GameBoard[0, 2] = "X";

            // ASSERT
            bool answer = game.CheckForWinner(board);
            Assert.True(answer);
        }
    }
}
