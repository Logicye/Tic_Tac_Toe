using ConsoleGameFramework.Graphics.StandardColorLibrary;
using ConsoleGameFramework.Objects;
using ConsoleGameFramework.Objects.Vectors;

namespace Tic_Tac_Toe.Game.Objects
{
	internal readonly struct Header
	{
		public readonly CenterPoint _center;
		public Header(int start, int end, int row) 
		{
			_center = new(start, end, row);
		}

		public void Update(GameState header, ColorPair colorPair)
		{
			colorPair.UseColor();
			string temp = _headers[(int)header];
			_center.WriteHorizontal(temp);
			ColorPair.Default.UseColor();
		}

		public void Update(GameState header)
		{
			Update(header, ColorPair.Default);
		}

		public static readonly string[] _headers =
		{
			"Player X's Turn",
			"Player Y's Turn",
			"Player X Wins",
			"Player Y Wins",
			"Drawn Game"
		};

		public static int ArrayLength => _headers.Length;
		public static int MaxLength => _headers.OrderByDescending(s => s.Length).First().Length;
	}
	internal enum GameState
	{
		TurnPlayer1,
		TurnPlayer2,
		WinPlayer1,
		WinPlayer2,
		GameDraw
	}
	
}
