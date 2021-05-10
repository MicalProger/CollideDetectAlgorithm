using System;

namespace collisiontest
{
    public class Vec2
    {
        public double X;
        public double Y;
        public Vec2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vec2(Vec2 v1, Vec2 v2)
        {
            Vec2 n = v1 + v2;
            X = n.X / 2;
            Y = n.Y / 2;
        }
        
        public double GetDistanceTo(Vec2 point) => Math.Sqrt(Math.Pow(X + point.X, 2) + Math.Pow(Y - point.Y, 2));
        
        public static Vec2 operator -(Vec2 v1, Vec2 v2)
        {
            return new Vec2(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vec2 operator +(Vec2 v1, Vec2 v2)
        {
            return new Vec2(v1.X + v2.X, v1.Y + v2.Y);
        }
    }
}