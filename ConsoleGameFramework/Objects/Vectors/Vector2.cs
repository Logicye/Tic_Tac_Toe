namespace ConsoleGameFramework.Objects.Vectors
{
#pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
	public struct Vector2 : IEquatable<Vector2>
#pragma warning restore CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
	{
		#region Properties
		public float X { get; }
		public float Y { get; }
		#endregion

		#region Constructors
		public Vector2(float x, float y) { X = x; Y = y; }
		public Vector2(Vector3 v) { X = v.X; Y = v.Y; }
		public Vector2(Vector4 v) { X = v.X; Y = v.Y; }
		#endregion

		#region Internal Function

		#endregion

		#region Standard Vector2's
		public static Vector2 Zero() => new(0, 0);
		public static Vector2 Left() => new(-1, 0);
		public static Vector2 Right() => new(1, 0);
		public static Vector2 Up() => new(0, 1);
		public static Vector2 Down() => new(0, -1);
		#endregion

		#region Operator Logic
		public static Vector2 operator +(Vector2 v1, Vector2 v2) => new(v1.X + v2.X, v1.Y + v2.Y);
		public static Vector2 operator -(Vector2 v1, Vector2 v2) => new(v1.X - v2.X, v1.Y - v2.Y);
		public static Vector2 operator *(Vector2 v1, Vector2 v2) => new(v1.X * v2.X, v1.Y * v2.Y);
		public static Vector2 operator /(Vector2 v1, Vector2 v2) => new(v1.X / v2.X, v1.Y / v2.Y);
		public static bool operator ==(Vector2 v1, Vector2 v2) => v1.Equals(v2);
		public static bool operator !=(Vector2 v1, Vector2 v2) => !v1.Equals(v2);
		#endregion

		#region Standard Methods
		public override readonly string ToString() => $"( X: {X}, Y: {Y} )";
		public readonly bool Equals(Vector2 other) => X == other.X && Y == other.Y;
		public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode();
		#endregion
	}
}
