namespace ConsoleGameFramework.Graphics.StandardColorLibrary
{
	public readonly struct ColorPair
	{
		private readonly Color _foreground;
		private readonly Color _background;

		public ColorPair(Color foreground, Color background)
		{
			this._foreground = foreground;
			this._background = background;
		}

		public ColorPair(Color color, bool Foreground, bool Readable)
		{
			if (Foreground)
			{
				this._foreground = color;
				if (Readable) _background = _foreground.ReadableColor();
				else _background = _foreground.Inverse();
			}
			else
			{
				this._background = color;
				if (Readable) _foreground = _background.ReadableColor();
				else _foreground = _background.Inverse();
			}
		}

		public void UseColor()
		{
			Console.ForegroundColor = _foreground.ReferenceColor;
			Console.BackgroundColor = _background.ReferenceColor;
		}

		public Color Foreground => _foreground;
		public Color Background => _background;
	}
}



