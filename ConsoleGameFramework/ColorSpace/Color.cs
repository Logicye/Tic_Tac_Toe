using System.ComponentModel;

namespace ConsoleGameFramework.ColorSpace
{
    public struct Color
    {
        public ConsoleColor ReferenceColor { get; }
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }

        public Color(ConsoleColor color, int r, int g, int b)
        {
            ReferenceColor = color;
            Red = r;
            Green = g;
            Blue = b;
        }
        public Color ReadableColor()
        {
            return FindFurtherestColor(Red, Green, Blue);
            /*
            if (ToArray().Sum() < (255 * 3) / 2)
            {
                return Colors.White;
            }
            return Colors.Black;
			*/
        }

        public Color Inverse()
        {
            return FindNearestColor(255 - Red, 255 - Green, 255 - Blue);
        }



        private static Color FindNearestColor(int r, int g, int b)
        {
            Color furtherest = Colors.White;
            int dif = 255 * 3;
            foreach (Color color in Colors.AllColors())
            {
                int dist = Convert.ToInt32(Math.Sqrt(
                    0.3 * Math.Pow(r - color.Red, 2) +
                    0.59 * Math.Pow(g - color.Green, 2) +
                    0.11 * Math.Pow(b - color.Blue, 2)));

                if (dist < dif)
                {
                    dif = dist;
                    furtherest = color;
                }
            }
            return furtherest;
        }

        private static Color FindFurtherestColor(int r, int g, int b)
        {
            Color furtherest = Colors.White;
            int dif = 0;
            foreach (Color color in Colors.AllColors())
            {
                int dist = Convert.ToInt32(Math.Sqrt(
                    0.3 * Math.Pow(r - color.Red, 2) +
                    0.59 * Math.Pow(g - color.Green, 2) +
                    0.11 * Math.Pow(b - color.Blue, 2)));

                if (dist > dif)
                {
                    dif = dist;
                    furtherest = color;
                }
            }
            return furtherest;
        }

        public static Color operator -(Color color1, Color color2)
        {
            return FindNearestColor(
                Convert.ToInt32(Math.Sqrt(color1.Red * color2.Red)),
                Convert.ToInt32(Math.Sqrt(color1.Green * color2.Green)),
                Convert.ToInt32(Math.Sqrt(color1.Blue * color2.Blue)));
        }

        public static Color operator +(Color color1, Color color2)
        {
            return FindFurtherestColor(
                (color1.Red + color2.Red) / 2,
                (color1.Green + color2.Green) / 2,
                (color1.Blue + color2.Blue) / 2);
        }

        public readonly int[] ToArray() => new int[3] { Red, Green, Blue };

    }
}
