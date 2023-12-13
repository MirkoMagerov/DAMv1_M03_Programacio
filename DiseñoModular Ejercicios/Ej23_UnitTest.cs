using Proyecto;

namespace ValidateTest
{
    [TestClass]
    public class ValidateTests
    {
        [TestMethod]
        public void ValidSquareCalculation_True()
        {
            // Arrange
            bool result;
            int expected = 25;
            int side = 5, elevateTo = 2;

            // Act
            result = ConsoleApp.AreaCalculator(side, elevateTo) == expected;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidRectangleCalculation_True()
        {
            // Arrange
            bool result;
            double expected = 20, side = 5, height = 4;

            // Act
            result = ConsoleApp.AreaCalculator(side, height) == expected;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidCircleCalculation_True()
        {
            // Arrange
            bool result;
            int elevateTo = 2;
            double expected = 15.21, radius = 2.2, piNumber = Math.PI;

            // Act
            result = Math.Round(ConsoleApp.AreaCalculator(radius, piNumber, elevateTo), 2) == expected;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidPentagonCalculation_True()
        {
            // Arrange
            bool result;
            int divideBy = 2, numberOfSides = 5;
            double expected = 15, side = 3, apotem = 2;

            // Act
            result = ConsoleApp.AreaCalculator(side, numberOfSides, apotem, divideBy) == expected;

            // Assert
            Assert.IsTrue(result);
        }
    }
}