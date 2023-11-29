using Proyecto;

namespace ValidateTest
{
    [TestClass]
    public class ValidateTests
    {
        [TestMethod]
        public void FactorialNumber()
        {
            // Arrange
            int expectedResult = 120, number = 5;
            int expectedResult2 = 1, number2 = 0;
            int expectedResult3 = 0, number3 = -5;

            // Act
            bool result, result2, result3;

            result = expectedResult == Proyecto.ConsoleApp.GetFactorial(number) ? true : false;
            result2 = expectedResult2 == Proyecto.ConsoleApp.GetFactorial(number2) ? true : false;
            result3 = expectedResult3 == Proyecto.ConsoleApp.GetFactorial(number3) ? true : false;

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
        }
    }
}