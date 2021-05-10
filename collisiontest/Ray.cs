using System.Collections.Generic;
using System.Linq;

namespace collisiontest
{
    public class Ray
    {
        public Vec2 pos;
        public double angle;
        public Ray(Vec2 start, double direction)
        {
            pos = start;
            angle = direction;
        }

        public Vec2 GetCollision(Vec2 p1, Vec2 p2)
        {
            var l = new List<Vec2>() {p1, p2};
            l = l.OrderBy(v => v.GetDistanceTo(pos)).ToList();
            var k = Tools.GetRads(angle);
            
        }
    }
}