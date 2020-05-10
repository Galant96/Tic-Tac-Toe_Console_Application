using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
			// Generate a new board
			Board board = new Board();

			// Set the win checker
			WinChecker winChecker = new WinChecker();

			// Render the game
			Renderer renderer = new Renderer();

			// Define the players
			Player player1 = new Player();
			Player player2 = new Player();

			// Process the gameplay, while it is not a draw and none player won
			while (!winChecker.IsDraw(board) && winChecker.Check(board) == State.Undecided)
			{
				// Render the board
				renderer.Render(board);
				renderer.DisplayeMovementOptions();

				Position nextMove;

				// Check whose is the turn
				if (board.NextTurn == State.X)
				{
					nextMove = player1.GetPosition(board);
				}
				else
				{
					nextMove = player2.GetPosition(board);
				}

				// Check if a player set its coordinate correctly
				if (!board.SetState(nextMove, board.NextTurn))
				{
					Console.WriteLine("The illegal move! Try again!");
				}
			}

			// Displaye the board and the final result
			renderer.Render(board);
			renderer.RenderResults(winChecker.Check(board));

			Console.ReadKey();
        }
    }
}
