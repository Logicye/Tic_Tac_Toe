using System.Drawing;

namespace ConsoleGameFramework.ColorSpace
{
    public static class Colors
    {
        public static Color White { get; } = new Color(ConsoleColor.White, 242, 242, 242);
        public static Color Black { get; } = new Color(ConsoleColor.Black, 12, 12, 12);
        public static Color Blue { get; } = new Color(ConsoleColor.Blue, 59, 120, 255);
        public static Color DarkBlue { get; } = new Color(ConsoleColor.DarkBlue, 0, 55, 218);
        public static Color Green { get; } = new Color(ConsoleColor.Green, 22, 198, 12);
        public static Color DarkGreen { get; } = new Color(ConsoleColor.DarkGreen, 19, 161, 14);
        public static Color Cyan { get; } = new Color(ConsoleColor.Cyan, 97, 214, 214);
        public static Color DarkCyan { get; } = new Color(ConsoleColor.DarkCyan, 58, 150, 221);
        public static Color Red { get; } = new Color(ConsoleColor.Red, 231, 72, 86);
        public static Color DarkRed { get; } = new Color(ConsoleColor.DarkRed, 197, 15, 31);
        public static Color Magenta { get; } = new Color(ConsoleColor.Magenta, 180, 0, 158);
        public static Color DarkMagenta { get; } = new Color(ConsoleColor.DarkMagenta, 136, 23, 152);
        public static Color Yellow { get; } = new Color(ConsoleColor.Yellow, 249, 241, 165);
        public static Color DarkYellow { get; } = new Color(ConsoleColor.DarkYellow, 193, 156, 0);
        public static Color Gray { get; } = new Color(ConsoleColor.Gray, 204, 204, 204);
        public static Color DarkGray { get; } = new Color(ConsoleColor.DarkGray, 118, 118, 118);

        public static IEnumerable<Color> AllColors()
        {
            yield return White;
            yield return Black;
            yield return Blue;
            yield return DarkBlue;
            yield return Green;
            yield return DarkGreen;
            yield return Cyan;
            yield return DarkCyan;
            yield return Red;
            yield return DarkRed;
            yield return Magenta;
            yield return DarkMagenta;
            yield return Yellow;
            yield return DarkYellow;
            yield return Gray;
            yield return DarkGray;

        }
    }
}
