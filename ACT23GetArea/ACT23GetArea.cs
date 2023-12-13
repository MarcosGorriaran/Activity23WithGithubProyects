using System;

namespace ACT23
{
    public class GetAreas
    {
        public static void Main()
        {
            
        }
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
            return 0.5 * apothem * (5 * length);
        }
    }
}