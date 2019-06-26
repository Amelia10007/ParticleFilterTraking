using System;

namespace ParticleFilterTraking.Backend
{
    readonly struct Position
    {
        public readonly int X;
        public readonly int Y;
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Position ChangeX(int newX) => new Position(newX, this.Y);
        public Position ChangeY(int newY) => new Position(this.X, newY);
        //この点と指定した点との距離を返す．
        public double Distance(Position other)
        {
            var dx = this.X - other.X;
            var dy = this.Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public override bool Equals(object obj) => obj is Position p && p.X == this.X && p.Y == this.Y;
        public override int GetHashCode() => this.X.GetHashCode() ^ this.Y.GetHashCode();
        public static Position operator +(Position lhs, Position rhs) => new Position(lhs.X + rhs.X, lhs.Y + rhs.Y);
        public static Position operator -(Position lhs, Position rhs) => new Position(lhs.X - rhs.X, lhs.Y - rhs.Y);
        public static Position operator *(Position p, int scalar) => new Position(p.X * scalar, p.Y * scalar);
    }
}
