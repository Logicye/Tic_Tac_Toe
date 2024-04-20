namespace ConsoleGameFramework.Objects.Vectors
{
#pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
	public struct Vector3 : IEquatable<Vector3>
#pragma warning restore CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
	{
		#region Properties
		public float X { get; }
		public float Y { get; }
		public float Z { get; }
		#endregion

		#region Constructors
		public Vector3(float x, float y, float z) { X = x; Y = y; Z = z; }
		public Vector3(Vector2 v, float z) { X = v.X; Y = v.Y; Z = z; }
		public Vector3(Vector4 v) { X = v.X; Y = v.Y; Z = v.Z; }

		#endregion


		#region Internal Function

		#endregion

		#region Standard Vector3's
		public static Vector3 Zero() => new Vector3(0, 0, 0);
		public static Vector3 Left() => new Vector3(-1, 0, 0);
		public static Vector3 Right() => new Vector3(1, 0, 0);
		public static Vector3 Up() => new Vector3(0, 1, 0);
		public static Vector3 Down() => new Vector3(0, -1, 0);
		#endregion

		#region Operator Logic
		public static Vector3 operator +(Vector3 v1, Vector3 v2) => new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
		public static Vector3 operator -(Vector3 v1, Vector3 v2) => new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
		public static Vector3 operator *(Vector3 v1, Vector3 v2) => new Vector3(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
		public static Vector3 operator /(Vector3 v1, Vector3 v2) => new Vector3(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
		public static bool operator ==(Vector3 v1, Vector3 v2) => v1.Equals(v2);
		public static bool operator !=(Vector3 v1, Vector3 v2) => !v1.Equals(v2);
		#endregion

		#region Standard Methods
		public bool Equals(Vector3 other) => X == other.X && Y == other.Y && Z == other.Z;
		public override readonly string ToString() => $"( X: {X}, Y: {Y}, Z: {Z} )";
		public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
		#endregion

	}
}