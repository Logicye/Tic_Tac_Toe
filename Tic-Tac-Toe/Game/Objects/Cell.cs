using ConsoleGameFramework.Graphics.StandardColorLibrary;
using ConsoleGameFramework.Objects.Vectors;

namespace Tic_Tac_Toe.Games.Objects
{
	internal class Cell
	{
		#region Console Colors For Cell State
		Color unselected;
		Color player1;
		Color player2;
		Color combined;

		ColorPair unselectedPair;
		ColorPair player1Pair;
		ColorPair player2Pair;
		ColorPair combinedPair;
		#endregion

		public Vector2 CellPosition { get; }
		private bool empty;
		private char value;

		public Cell(int row, int col)
		{
			empty = true;
			value = ' ';
			CellPosition = new Vector2(row, col);

			unselected = Colors.Black;
			player1 = Colors.Green;
			player2 = Colors.Red;
			combined = player1 - player2;

			unselectedPair = new ColorPair(unselected.ReadableColor(), unselected);
			player1Pair = new ColorPair(player1.ReadableColor(), player1);
			player2Pair = new ColorPair(player2.ReadableColor(), player2);
			combinedPair = new ColorPair(combined.ReadableColor(), combined);
		}

		public char Value() => value;
		public bool IsEmpty() => empty;

		public bool MakeMove(char player)
		{
			if (IsEmpty())
			{
				value = player;
				empty = false;
				return true;
			}
			return false;
		}

		public void DrawCell(Vector2 player1Cursor, Vector2 player2Cursor)
		{
			if (player1Cursor == player2Cursor && player1Cursor == CellPosition) combinedPair.UseColor();
			else if (player1Cursor == CellPosition) player1Pair.UseColor();
			else if (player2Cursor == CellPosition) player2Pair.UseColor();
			else unselectedPair.UseColor();
			Console.SetCursorPosition((int)CellPosition.X, (int)CellPosition.Y);
		}

	}
}
