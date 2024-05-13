using ConsoleGameFramework.Graphics.StandardColorLibrary;
using ConsoleGameFramework.Objects;
using ConsoleGameFramework.Objects.Assets.Menu;

namespace Tic_Tac_Toe.Game.Objects
{
    internal readonly struct BoardFrame : IFrame
	{
		private readonly FrameProperties _properties;
		private readonly List<string> _frames;
		public readonly int CellPadding { get; }
		public BoardFrame(int headerMaxLength, FrameProperties frameProperties) 
		{
			_properties = frameProperties;
			CellPadding = GetCellPadding(headerMaxLength);
			_frames = GenerateFrame();
		}
		public BoardFrame(int headerMaxLength)
		{
			_properties = new();
			CellPadding = GetCellPadding(headerMaxLength);
			_frames = GenerateFrame();
		}

		public Header InitHeader => new Header(0, Width, 2);

		public void Draw()
		{
			Console.SetCursorPosition(0, 0);
			foreach (var line in _frames)
			{
				foreach (var a in line)
				{
					if (a == _properties.whiteSpace && !_properties.colorizeWhiteSpace) ColorPair.Default.UseColor();
					else _properties.frameColor.UseColor();
					Console.Write(a);
				}
				Console.Write("\n");
			}
			ColorPair.Default.UseColor();
		}
		
		public int GetCellPadding(int headerMaxLength)
		{
			int padding = 1;
			while (true)
			{
				if (headerMaxLength + padding * 2 > padding * 6 + 5) padding++;
				else return padding;
			}
		}

		public List<string> GenerateFrame(bool headerless = false)
		{
			var frames = new List<string>();

			string rowDivider = 
				_properties.corner 
				+ new string(_properties.horizontalLine, CellPadding * 6 + 5) 
				+ _properties.corner;
			string vertEnds = 
				_properties.verticalLine 
				+ new string(_properties.whiteSpace, CellPadding * 6 + 5) 
				+ _properties.verticalLine;
			string cellDivider = 
				_properties.corner
				+ new string(_properties.horizontalLine, CellPadding * 2 + 1)
				+ _properties.corner
				+ new string(_properties.horizontalLine, CellPadding * 2 + 1)
				+ _properties.corner
				+ new string(_properties.horizontalLine, CellPadding * 2 + 1) 
				+ _properties.corner;
			string vertCells =
				_properties.verticalLine
				+ new string(_properties.whiteSpace, CellPadding * 2 + 1)
				+ _properties.verticalLine
				+ new string(_properties.whiteSpace, CellPadding * 2 + 1)
				+ _properties.verticalLine
				+ new string(_properties.whiteSpace, CellPadding * 2 + 1)
				+ _properties.verticalLine;

			frames.Add(rowDivider);
			for (int i = 0; i < 3; i++)
			{
				frames.Add(vertEnds);
			}

			frames.Add(cellDivider);
			for(int i = 0; i < 3; i++)
			{
				if (CellPadding % 2 == 0) for (int j = 0; j < CellPadding + 1; j++) frames.Add(vertCells);
				else for (int j = 0; j < CellPadding; j++) frames.Add(vertCells);
				frames.Add(cellDivider);
			}
			return frames;
		}
		public readonly int Length => _frames.Count;
		public readonly int Width => _frames[0].Length;
		public readonly string[] ToArray => _frames.ToArray();
	}
}
