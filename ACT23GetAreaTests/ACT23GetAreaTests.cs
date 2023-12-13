using ACT23;

namespace ACT23GetAreaTests
{
    [TestClass]
    public class ACT23GetAreaTests
    {
        [TestMethod]
        public void GetAreaSquare()
        {
            //Arrange
            double squareLength = -5;
            double expected = 25;
            double result;

            //Act
            result = GetAreas.GetAreaSquare(squareLength);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAreaSquareByZero()
        {
            //Arrange
            double squareLength = 0;
            double expected = 0;
            double result;

            //Act
            result = GetAreas.GetAreaSquare(squareLength);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAreaRectangle()
        {
            //Arrange
            double squareLength = -5;
            double secondSquareLength = 9;
            double expected = -45;
            double result;

            //Act
            result = GetAreas.GetAreaSquare(squareLength, secondSquareLength);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAreaRectangleByZero()
        {
            //Arrange
            double squareLength = 0;
            double secondSquareLength = 9;
            double expected = 0;
            double result;

            //Act
            result = GetAreas.GetAreaSquare(squareLength, secondSquareLength);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAreaCircle()
        {
            //Arrange
            double circleRadius = 10;
            double expected = 314.159;
            double result;

            //Act
            result = GetAreas.GetAreaCircle(circleRadius);
            result = Math.Round(result, 3, MidpointRounding.ToZero);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAreaCircleByZero()
        {
            //Arrange
            double circleRadius = 0;
            double expected = 0;
            double result;

            //Act
            result = GetAreas.GetAreaCircle(circleRadius);
            result = Math.Round(result, 3, MidpointRounding.ToZero);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetPentagonArea()
        {
            //Arrange
            double apothem = 10;
            double length = 4;
            double expected = 100;
            double result;

            //Act
            result = GetAreas.GetAreaPentagon(apothem, length);

            //Assert
            Assert.AreEqual(expected, result);
        }
        public void GetPentagonAreaByZero()
        {
            //Arrange
            double apothem = 0;
            double length = 4;
            double expected = 0;
            double result;

            //Act
            result = GetAreas.GetAreaPentagon(apothem, length);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}