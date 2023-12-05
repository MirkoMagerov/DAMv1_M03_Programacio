using Proyecto;

namespace ValidateTest
{
    [TestClass]
    public class ValidateTests
    {
        [TestMethod]
        public void NumberEqualsMinRange_True()
        {
            // Arrange
            bool result;
            int number = 15, minRange = 15, maxRange = 100;

            // Act
            result = ConsoleApp.NumberInRange(number, minRange, maxRange);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NumberEqualsMaxRange_True()
        {
            // Arrange
            bool result;
            int number = 100, minRange = 15, maxRange = 100;

            // Act
            result = ConsoleApp.NumberInRange(number, minRange, maxRange);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidNumberInRange_False()
        {
            // Arrange
            bool result;
            int number = 35, minRange = 15, maxRange = 100;

            // Act
            result = ConsoleApp.NumberInRange(number, minRange, maxRange);

            // Assert
            Assert.IsFalse(result);
        }
    }
}