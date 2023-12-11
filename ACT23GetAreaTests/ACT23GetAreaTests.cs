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
    }
}