using System;

namespace ACT23
{
    public class ACT23
    {
        public static double GetAreaSquare(double length)
        {
            return length * length;
        }
        public static double GetAreaSquare (double firstLength, double secondLength)
        {
            return firstLength * secondLength;
        }
        public static double GetAreaCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
        public static double GetAreaPentagon(double apothem, double length)
        {
            return 1 / 2 * apothem * 5 * length;
        }
    }
}