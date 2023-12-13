using System;

namespace ACT23
{
    public class GetAreas
    {
        public static void Main()
        {
            const string WelcomeMsg = "Welcome to this program which will calculate the area of a square, a rectangle, a circle and a pentagon: ";
            const string AskSquareLength = "Provide me with the length of the square: ";
            const string AskRectangleLengths = "Provide me with the length of both sides of the rectangle splited with a blank space: ";
            const string AskCircleRadius = "Provide me with the radius of the circle: ";
            const string AskPentagonApothem = "Provide me with the apothem of the pentagon: ";
            const string AskPentagonLength = "Provide me with the Length of the pentagon: ";

            string length;

            
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