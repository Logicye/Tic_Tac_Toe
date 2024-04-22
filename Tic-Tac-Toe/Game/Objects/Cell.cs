using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameFramework.Graphics.StandardColorLibrary;
using ConsoleGameFramework.Objects.Vectors;

namespace Tic_Tac_Toe.Game.Objects
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
        public Vector2 ConsolePosition { get; }
        private bool empty;
        private char value;

        public Cell(int consoleX, int consoleY, int x, int y)
        {
            empty = true;
            value = ' ';
            ConsolePosition = new Vector2(consoleX, consoleY);
            CellPosition = new Vector2(x, y);

            unselected = Colors.Black;
            player1 = Colors.DarkGreen;
            player2 = Colors.DarkRed;
            combined = player1 - player2;

			unselectedPair = new ColorPair(unselected.ReadableColor(), unselected);
			player1Pair = new ColorPair(player1.ReadableColor(), player1);
			player2Pair = new ColorPair(player2.ReadableColor(), player2);
			combinedPair = new ColorPair(combined.ReadableColor(), combined);
		}

        public char Value => value;
        public bool IsEmpty => empty;

        public bool MakeMove(char player)
        {
            if (IsEmpty)
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
            ConsolePosition.CursorTo();
            Console.Write(Value.ToString());
        }

    }
}
