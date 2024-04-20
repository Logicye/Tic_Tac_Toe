namespace ConsoleGameFramework.Graphics.StandardColorLibrary
{
    public struct ColorPair
    {
        private readonly Color foreground;
        private readonly Color background;

        public ColorPair(Color foreground, Color background)
        {
            this.foreground = foreground;
            this.background = background;
        }

        public ColorPair(Color color, bool Foreground, bool Readable)
        {
            if (Foreground)
            {
                this.foreground = color;
				if (Readable) background = foreground.ReadableColor();
				else background = foreground.Inverse();
			}
            else
            {
                this.background = color;
				if (Readable) foreground = background.ReadableColor();
				else foreground = background.Inverse();
			}
        }

        public void UseColor()
        {
            Console.ForegroundColor = foreground.ReferenceColor;
            Console.BackgroundColor = background.ReferenceColor;
        }

        public Color Foreground => foreground;
		public Color Background => background;
	}
}



