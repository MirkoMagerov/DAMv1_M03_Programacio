using Proyecto;

namespace ValidateTest
{
    [TestClass]
    public class ValidateTests
    {
        [TestMethod]
        public void ValidValue_True()
        {
            // Arrange
            bool result;
            int year = 2020;

            // Act
            result = ConsoleApp.IsBisiesto(year);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WrongValue_False()
        {
            // Arrange
            bool result;
            int year = 1900;

            // Act
            result = ConsoleApp.IsBisiesto(year);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidValue_SecondTrue()
        {
            // Arrange
            bool result;
            int year = 1600;

            // Act
            result = ConsoleApp.IsBisiesto(year);

            // Assert
            Assert.IsTrue(result);
        }
    }
}