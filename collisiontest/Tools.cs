using System;

namespace collisiontest
{
    public static class Tools
    {
        public static double GetRads(double val)
        {
            val *= Math.PI;
            val /= 180;
            return val;
        }
    }
}