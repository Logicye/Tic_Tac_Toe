﻿namespace ConsoleGameFramework.Objects.Vectors
{
    public struct Vector4 : IEquatable<Vector4>
    {
        #region Properties
        public float X { get; }
        public float Y { get; }
        public float Z { get; }
        public float W { get; }
        #endregion

        #region Constructors
        public Vector4(float x, float y, float z, float w) { X = x; Y = y; Z = z; W = w; }
        public Vector4(Vector2 v, float z, float w) { X = v.X; Y = v.Y; Z = z; W = w; }
        public Vector4(Vector3 v, float w) { X = v.X; Y = v.Y; Z = v.Z; W = w; }
        #endregion

        #region Internal Function

        #endregion

        #region Standard Vector3's
        public static Vector4 Zero() => new Vector4(0, 0, 0, 0);
        public static Vector4 Left() => new Vector4(-1, 0, 0, 0);
        public static Vector4 Right() => new Vector4(1, 0, 0, 0);
        public static Vector4 Up() => new Vector4(0, 1, 0, 0);
        public static Vector4 Down() => new Vector4(0, -1, 0, 0);
        #endregion

        #region Operator Logic
        public bool Equals(Vector4 other) => X == other.X && Y == other.Y && Z == other.Z ? true : false;
        public static Vector4 operator +(Vector4 v1, Vector4 v2) => new Vector4(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z, v1.W + v2.W);
        public static Vector4 operator -(Vector4 v1, Vector4 v2) => new Vector4(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z, v1.W - v2.W);
        public static Vector4 operator *(Vector4 v1, Vector4 v2) => new Vector4(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z, v1.W * v2.W);
        public static Vector4 operator /(Vector4 v1, Vector4 v2) => new Vector4(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z, v1.W / v2.W);
        public static bool operator ==(Vector4 v1, Vector4 v2) => v1.Equals(v2);
        public static bool operator !=(Vector4 v1, Vector4 v2) => !v1.Equals(v2);
        #endregion

        #region Standard Methods
        public override readonly string ToString() => $"( X: {X}, Y: {Y}, Z: {Z} W: {W})";
        #endregion
    }
}