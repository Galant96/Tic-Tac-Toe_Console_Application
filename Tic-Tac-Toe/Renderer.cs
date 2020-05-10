using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic_Tac_Toe
{
	// Renderer class is responsible for rendering the game's gameplay in the console window
	class Renderer
	{
		/// <summary>
		/// Render the board
		/// </summary>
		/// <param name="board">The current board</param>
		public void Render(Board board)
		{
			// Store symbols values on the board
			char[,] symbols = new char[3, 3];

			// Set states on the board
			for (int row = 0; row < 3; row++)
			{
				for (int column = 0; column < 3; column++)
				{
					symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));
				}
			}

			// Write the board in the console window
			Console.WriteLine($" {symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]} | ");
			Console.WriteLine("===+===+===");
			Console.WriteLine($" {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]} | ");
			Console.WriteLine("===+===+===");
			Console.WriteLine($" {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]} | ");
		}

		/// <summary>
		/// Return symbol for the given state
		/// </summary>
		/// <param name="state">The current state</param>
		private char SymbolFor(State state)
		{
			switch(state)
			{
				case State.O: return 'O';
				case State.X: return 'X';
				default: return ' ';
			}
		}

		/// <summary>
		/// Display the final results
		/// </summary>
		/// <param name="winner"> The winner's state (symbol) </param>
		public void RenderResults(State winner)
		{
			switch (winner)
			{
				case State.Undecided:
					Console.WriteLine("Draw!!!");
					break;
				case State.X:
				case State.O:
					Console.WriteLine(SymbolFor(winner) + " Wins!!!");
					break;
				default:
					break;
			}
		}
	}
}
