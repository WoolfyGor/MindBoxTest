using figuresCalculator;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Circle_WithValidResult_CalculateCircle()
        {
            // Arrange
            float radius = 12;
            float expected = 452.3893f;

            figureCalculate calculator = new figureCalculate();

            // Act
            var result = calculator.calculateCircle(radius);

            // Assert
            double actual = result;
            Assert.AreEqual(expected, actual, 0.1, "Test not passed");
        }
        [TestMethod]
        public void Circle_WithInvalidResult_CalculateCircle()
        {
            // Arrange
            float radius = 10;
            float expected = 452.3893f;

            figureCalculate calculator = new figureCalculate();

            // Act
            var result = calculator.calculateCircle(radius);

            // Assert
            double actual = result;
            Assert.AreEqual(expected, actual, 0.1, "Test not passed");
        }
        [TestMethod]
        public void Triangle_WithValidResult_CalculateTriangle()
        {
            // Arrange
            float firstSide = 4.3f;
            float secondSide = 3f;
            float thirdSide = 4f;
            float expected = 5.775f;

            figureCalculate calculator = new figureCalculate();

            // Act
            var result = calculator.caltulateTriangle(firstSide,secondSide,thirdSide);

            // Assert
            double actual = result;
            Assert.AreEqual(expected, actual, 0.1, "Test not passed");
        }
        [TestMethod]
        public void Triangle_asRectangle_CalculateCircle()
        {
            // Arrange
            float firstSide = 15f;
            float secondSide = 4f;
            float expected = 60f;

            figureCalculate calculator = new figureCalculate();

            // Act
            var result = calculator.caltulateTriangle(firstSide, secondSide);

            // Assert
            double actual = result;
            Assert.AreEqual(expected, actual, 0.1, "Test not passed");
        }
    }
}