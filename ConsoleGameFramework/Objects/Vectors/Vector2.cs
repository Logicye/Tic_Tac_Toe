namespace ConsoleGameFramework.Objects.Vectors
{
    public struct Vector2 : IEquatable<Vector2>
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
        public static Vector2 Zero() => new Vector2(0, 0);
        public static Vector2 Left() => new Vector2(-1, 0);
        public static Vector2 Right() => new Vector2(1, 0);
        public static Vector2 Up() => new Vector2(0, 1);
        public static Vector2 Down() => new Vector2(0, -1);
        #endregion

        #region Operator Logic
        public bool Equals(Vector2 other) => X == other.X && Y == other.Y ? true : false;
        public static Vector2 operator +(Vector2 v1, Vector2 v2) => new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        public static Vector2 operator -(Vector2 v1, Vector2 v2) => new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        public static Vector2 operator *(Vector2 v1, Vector2 v2) => new Vector2(v1.X * v2.X, v1.Y * v2.Y);
        public static Vector2 operator /(Vector2 v1, Vector2 v2) => new Vector2(v1.X / v2.X, v1.Y / v2.Y);
        public static bool operator ==(Vector2 v1, Vector2 v2) => v1.Equals(v2);
        public static bool operator !=(Vector2 v1, Vector2 v2) => !v1.Equals(v2);
        #endregion

        #region Standard Methods
        public override readonly string ToString() => $"( X: {X}, Y: {Y} )";
        #endregion
    }
}
