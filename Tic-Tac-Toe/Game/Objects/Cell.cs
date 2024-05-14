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
        private char _value;
        private int _padding;

        public Cell(int x, int y, int padding)
        {
            _value = ' ';
            _padding = padding;
            ConsolePosition = new(_padding * (2 * x + 1) + (2 * x + 1), _padding / 2 * (2 * y + 1) + 5 + (2 * y));
			CellPosition = new Vector2(x, y);
			SetColors();
        }

        public void SetColors()
        {
			unselected = Colors.Black;
			player1 = Colors.DarkBlue;
			player2 = Colors.DarkRed;
			combined = player1 + player2;

			unselectedPair = new ColorPair(unselected.ReadableColor(), unselected);
			player1Pair = new ColorPair(player1.ReadableColor(), player1);
			player2Pair = new ColorPair(player2.ReadableColor(), player2);
			combinedPair = new ColorPair(combined.ReadableColor(), combined);
		}

        public char Value => _value;
        public bool IsEmpty => _value == ' ' ? true : false;

        public bool MakeMove(char player)
        {
            if (IsEmpty)
            {
                _value = player;
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
            
            for(int x = -_padding; x < _padding + 1; x++)
            {
                for(int y = -_padding/2; y < _padding/2 + 1; y++)
                {
                    Console.SetCursorPosition((int)ConsolePosition.X + x, (int)ConsolePosition.Y + y);
                    if (x == 0 && y == 0) Console.Write(_value.ToString());
                    else Console.Write(" ");
                }
            }
        }
    }
}
