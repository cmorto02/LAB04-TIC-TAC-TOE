using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Player
    {
		public string Name { get; set; }
		/// <summary>
		/// P1 is X and P2 will be O
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		/// Flag to determine if it is the user's turn
		/// </summary>
		public bool IsTurn { get; set; }

        /// <summary>
        /// This asks the player to select a location on the gameboard and then parses the players response
        /// </summary>
        /// <param name="board">This methods takes in the board object as a parameter.</param>
        /// <returns>The coorinates on the gameboard</returns>
		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}
        /// <summary>
        /// Switch statement that takes in the parsed user response and returns a board coordinate.
        /// </summary>
        /// <param name="position">User input converted to an int</param>
        /// <returns>Board coordinates</returns>
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}

	    /// <summary>
        /// This function tells the player when it is their turn and tells the player if a space is already occupied.
        /// </summary>
        /// <param name="board">Takes in the current board object</param>
		public void TakeTurn(Board board)
		{
			IsTurn = true;

            bool filled = true;

            while (filled)
            {
                Console.WriteLine($"{Name} it is your turn");
                Position position = GetPosition(board);

                if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
                {
                    board.GameBoard[position.Row, position.Column] = Marker;
                    filled = false;
                }
                else
                {
                    Console.WriteLine("This space is already occupied");
                }
            }
		}
	}
}
