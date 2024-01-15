using Refactoring;

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
            int userNumber = 10, minValue = 5, maxValue = 150;

            // Act
            result = FirstRefactoringExercise.NumberInRange(userNumber, minValue, maxValue);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LowerThanMinValue_False()
        {
            // Arrange
            bool result;
            int userNumber = 3, minValue = 5, maxValue = 150;

            // Act
            result = FirstRefactoringExercise.NumberInRange(userNumber, minValue, maxValue);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HigherThanMaxValue_False()
        {
            // Arrange
            bool result;
            int userNumber = 160, minValue = 5, maxValue = 150;

            // Act
            result = FirstRefactoringExercise.NumberInRange(userNumber, minValue, maxValue);

            // Assert
            Assert.IsFalse(result);
        }
    }
}