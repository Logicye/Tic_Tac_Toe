namespace ConsoleGameFramework.Graphics.StandardColorLibrary
{
    public static class Colors
    {
        private static readonly Color[] colors = new Color[]
        {
            new Color(ConsoleColor.White, 242, 242, 242),
            new Color(ConsoleColor.Black, 12, 12, 12),
            new Color(ConsoleColor.Blue, 59, 120, 255),
            new Color(ConsoleColor.DarkBlue, 0, 55, 218),
            new Color(ConsoleColor.Green, 22, 198, 12),
            new Color(ConsoleColor.DarkGreen, 19, 161, 14),
            new Color(ConsoleColor.Cyan, 97, 214, 214),
            new Color(ConsoleColor.DarkCyan, 58, 150, 221),
            new Color(ConsoleColor.Red, 231, 72, 86),
            new Color(ConsoleColor.DarkRed, 197, 15, 31),
            new Color(ConsoleColor.Magenta, 180, 0, 158),
            new Color(ConsoleColor.Yellow, 249, 241, 165),
            new Color(ConsoleColor.DarkYellow, 193, 156, 0),
            new Color(ConsoleColor.Gray, 204, 204, 204),
            new Color(ConsoleColor.DarkMagenta, 136, 23, 152),
            new Color(ConsoleColor.DarkGray, 118, 118, 118)
        };

        public static Color[] All {get{return colors;}}

		public static Color White => colors[0];
        public static Color Black => colors[1];
        public static Color Blue => colors[2];
        public static Color DarkBlue => colors[3];
        public static Color Green => colors[4];
        public static Color DarkGreen => colors[5];
        public static Color Cyan => colors[6];
        public static Color DarkCyan => colors[7];
        public static Color Red => colors[8];
        public static Color DarkRed => colors[9];
        public static Color Magenta => colors[10];
        public static Color DarkMagenta => colors[11];
        public static Color Yellow => colors[12];
        public static Color DarkYellow => colors[13];
        public static Color Gray => colors[14];
        public static Color DarkGray => colors[15];
    }
}
