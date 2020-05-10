using System;
using System.Collections.Generic;
using System.Linq;


namespace Tic_Tac_Toe
{
	// Position class is responsible for keeping a position on the board

	class Position
	{
		public int Row { get;}
		public int Column { get;}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="row">The row position </param>
		/// <param name="column"> The column position </param>
		public Position(int row, int column)
		{
			Row = row;
			Column = column;
		}
	}
}
