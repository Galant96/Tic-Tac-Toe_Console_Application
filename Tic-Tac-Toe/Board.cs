using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic_Tac_Toe
{
	// Board class is responsible for generating the board

	class Board
	{
		// Properties

		// Set 2D array for storing states on the board
		private State[,] state;
		// Determines whose turn is next
		public State NextTurn { get; set; } 

		/// <summary>
		/// Constructor
		/// </summary>
		public Board()
		{
			// Initialise the board to undefined
			state = new State[3, 3]; 
			NextTurn = State.X;
		}

		/// <summary>
		/// Return state for the given position
		/// </summary>
		/// <param name="position">The given position</param>
		/// <returns></returns>
		public State GetState(Position position)
		{
			return state[position.Row, position.Column];
		}

		/// <summary>
		/// Check the current turn
		/// </summary>
		/// <param name="position">The given position is needed to check if it is not already filled</param>
		/// <param name="newState">Get the current state to check if it is the correct turn</param>
		public bool SetState(Position position, State newState)
		{
			// Return false if it is not your turn
			if (newState != NextTurn)
			{
				return false;
			}

			// Return false if the given position is already filled
			if (state[position.Row, position.Column] != State.Undecided)
			{
				return false;
			}

			// Set a new state
			state[position.Row, position.Column] = newState;
			SwitchNextTurn();
			// Else return true
			return true;
		}

		/// <summary>
		/// Switch between states
		/// </summary>
		private void SwitchNextTurn()
		{
			if (NextTurn == State.X)
			{
				NextTurn = State.O;
			}
			else
			{
				NextTurn = State.X;
			}
		}
	}
}
