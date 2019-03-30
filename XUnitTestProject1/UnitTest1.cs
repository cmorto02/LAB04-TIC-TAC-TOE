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
        [Fact]
        public void ICanSwitchPlayers()
        {
            Board board = new Board();

            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;

            game.PlayerOne.IsTurn = true;
            game.PlayerOne.IsTurn = false;


            // ACT
            game.SwitchPlayer();

            // ASSERT
            Assert.True(game.PlayerOne.IsTurn);
        }
        [Fact]
        public void ICanPickTheCorrectSpot()
        {
            Board board = new Board();

            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;

            // ACT
            Position position = Player.PositionForNumber(1);
            // ASSERT
            Assert.Equal(0, position.Row);
            Assert.Equal(0, position.Column);
        }
        [Fact]
        public void Player1ShouldHaveAName()
        {
            // Arrange
            Player p1 = new Player()
            {
                // Act
                Name = "Chris"
            };
            // Assert
            Assert.Equal("Chris", p1.Name );
        }
    }
}
