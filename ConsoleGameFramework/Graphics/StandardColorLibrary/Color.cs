using static System.Math;
namespace ConsoleGameFramework.Graphics.StandardColorLibrary
{
	public readonly struct Color
	{
		public ConsoleColor ReferenceColor { get; }
		public byte Red { get; }
		public byte Green { get; }
		public byte Blue { get; }

		public Color(ConsoleColor color, byte r, byte g, byte b) => new Color(color, r, g, b);

		public Color ReadableColor() => FindFurtherestColor(Red, Green, Blue);

		public Color Inverse() => FindNearestColor((byte)(255 - Red), (byte)(255 - Green), (byte)(255 - Blue));

		private static int Dist((byte Red, byte Green, byte Blue) c1, Color c2) =>
			(int)Sqrt(0.3 * Pow(c1.Red - c2.Red, 2) + 0.59 * Pow(c1.Green - c2.Green, 2) + 0.11 * Pow(c1.Blue - c2.Blue, 2));

		private static Color FindNearestColor(byte r, byte g, byte b) =>
			Colors.All.OrderBy(color => Dist((r, g, b), color)).First();

		private static Color FindFurtherestColor(byte r, byte g, byte b) =>
			Colors.All.OrderByDescending(color => Dist((r, g, b), color)).First();

		public static Color operator -(Color c1, Color c2) =>
			FindNearestColor(
				(byte)(Sqrt(c1.Red * c2.Red)),
				(byte)(Sqrt(c1.Green * c2.Green)),
				(byte)(Sqrt(c1.Blue * c2.Blue)));

		public static Color operator +(Color c1, Color c2) =>
			FindFurtherestColor(
				(byte)((c1.Red + c2.Red) / 2),
				(byte)((c1.Green + c2.Green) / 2),
				(byte)((c1.Blue + c2.Blue) / 2));

		public readonly int[] ToArray() => new int[3] { Red, Green, Blue };

		public readonly override string ToString() => new($"( {ReferenceColor}: {Red} , {Green} , {Blue} )");

	}
}
