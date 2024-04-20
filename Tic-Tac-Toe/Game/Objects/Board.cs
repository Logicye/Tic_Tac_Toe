namespace Tic_Tac_Toe.Games.Objects
{
	internal class Board
	{
		public Cell[,] GameBoard { get; }

		public Board()
		{
			GameBoard = new Cell[3, 3]
			{
				{new Cell(0,0), new Cell(0,1), new Cell(0,2) },
				{new Cell(1,0), new Cell(1,1), new Cell(1,2) },
				{new Cell(2,0), new Cell(2,1), new Cell(2,2) }
			};
		}
	}
}
