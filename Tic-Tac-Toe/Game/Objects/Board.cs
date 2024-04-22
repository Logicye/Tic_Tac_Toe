using ConsoleGameFramework.Graphics.StandardColorLibrary;
using Tic_Tac_Toe.Game.Players;

namespace Tic_Tac_Toe.Game.Objects
{
    internal class Board
    {
        private Header _header;
        private BoardFrame _frame;
        //Using the postions reference of [ x , y ] = [ row , col ]
        public List<Cell> GameBoard { get; }

        public Board() 
        {
            GameBoard = new ();
            _frame = new BoardFrame(Header.MaxLength);
            _header = _frame.InitHeader(0, Header.MaxLength, 2);
        }

        public void Initialize()
        {
			SetCellPositions();
			FillBuffer();
            _frame.Draw();
        }

        public void Update( GameState gameState, IPlayer player1, IPlayer player2)
        {
			_header.Update(gameState);
			foreach(var cell in GameBoard) cell.DrawCell(player1.CursorPositon, player2.CursorPositon);
            ColorPair.Default.UseColor();
        }

        private void SetCellPositions()
        {
            int headerOffset    = 5;
            //int rowOffset       = 0;
            //int colOffset       = 0;

            //Row 1 Setters
            GameBoard.Add(new Cell(_frame.CellPadding + 1,     _frame.CellPadding / 2 + headerOffset,   0, 0));
			GameBoard.Add(new Cell(_frame.CellPadding * 3 + 3, _frame.CellPadding / 2 + headerOffset,   1, 0));
			GameBoard.Add(new Cell(_frame.CellPadding * 5 + 5, _frame.CellPadding / 2 + headerOffset,   2, 0));
            //Row 2 Setters
 			GameBoard.Add(new Cell(_frame.CellPadding + 1,     _frame.CellPadding / 2 * 3 + headerOffset + 2,   0, 1));
			GameBoard.Add(new Cell(_frame.CellPadding * 3 + 3, _frame.CellPadding / 2 * 3 + headerOffset + 2,   1, 1));
			GameBoard.Add(new Cell(_frame.CellPadding * 5 + 5, _frame.CellPadding / 2 * 3 + headerOffset + 2,   2, 1));
            //Row 3 Setters
 			GameBoard.Add(new Cell(_frame.CellPadding + 1,     _frame.CellPadding / 2 * 5 + headerOffset + 4,   0, 2));
			GameBoard.Add(new Cell(_frame.CellPadding * 3 + 3, _frame.CellPadding / 2 * 5 + headerOffset + 4,   1, 2));
			GameBoard.Add(new Cell(_frame.CellPadding * 5 + 5, _frame.CellPadding / 2 * 5 + headerOffset + 4,   2, 2));
		}
        
		private void FillBuffer()
		{
			for (int i = 0; i < _frame.Length; i++) Console.WriteLine();
		}
	}
}
