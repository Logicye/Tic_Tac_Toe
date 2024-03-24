using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Games.GameObjects
{
    internal class Cell
    {
        public Point Position { get; }
        public bool Empty { get; }
        public char Value { get; }

        public Cell(int row, int col) 
        {
            Empty = true;
            Value = ' ';
            Position = new Point(row, col);
        }
    }
}
