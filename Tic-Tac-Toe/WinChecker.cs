using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic_Tac_Toe
{
	class WinChecker
	{
		/// <summary>
		/// Check if one of the players won 
		/// </summary>
		/// <param name="board">The current board</param>
		/// <returns></returns>
		public State Check(Board board)
		{
			if (CheckForWin(board, State.X))
			{
				return State.X;
			}

			if (CheckForWin(board, State.O))
			{
				return State.O;
			}

			return State.Undecided;
		}

		/// <summary>
		/// Check if a win has been reached along the rows, the columns or the diagonals
		/// </summary>
		/// <param name="board">The current board</param>
		/// <param name="player">The current player</param>
		/// <returns></returns>
		private bool CheckForWin(Board board, State player)
		{
			for (int row = 0; row < 3; row++)
			{
				if (AreAll(board, new Position[] {
					new Position(row, 0),
					new Position(row, 1),
					new Position(row, 2) }, player))
				{
					return true;
				}
			}

			for (int column = 0; column < 3; column++)
			{
				if (AreAll(board, new Position[] {
					new Position(0, column),
					new Position(1, column),
					new Position(2, column) }, player))
				{
					return true;
				}
			}

			if (AreAll(board, new Position[] {
					new Position(0, 0),
					new Position(1, 1),
					new Position(2, 2) }, player))
			{
				return true;
			}

			if (AreAll(board, new Position[] {
					new Position(2, 0),
					new Position(1, 1),
					new Position(2, 2) }, player))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Iterate through all psoitions to see if they are equall for the current state
		/// </summary>
		/// <param name="board">The current board</param>
		/// <param name="positions">The given psoitions on the board</param>
		/// <param name="state">The kind of state to check</param>
		/// <returns></returns>
		private bool AreAll(Board board, Position[] positions, State state)
		{
			foreach (Position position in positions)
			{
				if (board.GetState(position) != state)
				{
					return false;
				}
			}
			return true;

		}

		/// <summary>
		/// Check if it is a draw
		/// </summary>
		/// <param name="board">The current board</param>
		/// <returns></returns>
		public bool IsDraw(Board board)
		{
			for (int row = 0; row < 3; row++)
			{
				for (int column = 0; column < 3; column++)
				{
					// If there is any undefined state on the board then the game is still playable
					if (board.GetState(new Position(row, column)) == State.Undecided)
					{
						return false;
					}

				}
			}

			return true;

		}
	}

}
