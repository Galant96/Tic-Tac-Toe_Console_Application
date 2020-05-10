using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic_Tac_Toe
{
	// Player class is responsible for handling the player's chosen positions

	class Player
	{
		/// <summary>
		/// Get the player's position
		/// </summary>
		/// <param name="board"> The current board </param>
		/// <returns></returns>
		public Position GetPosition(Board board)
		{
			// Get input from the player
			int position = Convert.ToInt32(Console.ReadLine());

			// Choose player's chosen coordinate
			Position playerCoordinate = ChoosePosition(position);

			return playerCoordinate;
		}

		/// <summary>
		/// Choose the position of the player's move
		/// </summary>
		/// <param name="position"> The player's chosen position </param>
		private Position ChoosePosition(int position)
		{
			switch (position)
			{
				case 1:
					return new Position(0, 0); // Top left
				case 2:
					return new Position(0, 1); // Top mid
				case 3:
					return new Position(0, 2); // Top right

				case 4:
					return new Position(1, 0); // Mid left
				case 5:
					return new Position(1, 1); // Mid mid
				case 6:
					return new Position(1, 2); // Mid right

				case 7:
					return new Position(2, 0); // Bottom left
				case 8:
					return new Position(2, 1); // Bottom mid
				case 9:
					return new Position(2, 2); // Bottom right

				default:
					return null;
			}
		}
	}
}
