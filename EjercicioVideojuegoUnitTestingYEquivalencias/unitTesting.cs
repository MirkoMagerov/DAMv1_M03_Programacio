using Activitats;

namespace ValidateTest
{
    [TestClass]
    public class ValidateTests
    {
        [TestMethod]
        public void NombreConMasDe10Caracteres()
        {
            // Arrange
            string name = "ABCDEFGHIJKLMN";
            bool isWrongName;

            // Act
            isWrongName = ej31.validarNom(name);

            // Assert
            Assert.IsFalse(isWrongName);
        }

        [TestMethod]
        public void NombreConMenosDe10Carácteres()
        {
            // Arrange
            string name = "Abcd";
            bool isCorrectName;

            // Act
            isCorrectName = ej31.validarNom(name);

            // Assert
            Assert.IsTrue(isCorrectName);
        }

        [TestMethod]
        public void NúmeroIntroducidoPorUsuarioFueraDelRango()
        {
            // Arrange
            int wrongNumber = 550;
            bool isInRange;

            // Act
            isInRange = ej31.validarRang(wrongNumber);

            // Assert
            Assert.IsTrue(isInRange);
        }

        [TestMethod]
        public void NumerosIntroducidosPorUsuarioDentroDelRango()
        {
            // Arrange
            int mediumNumber = 300, minNumber = 1, maxNumber = 500;
            bool isInRange;

            // Act
            isInRange = ej31.validarRang(mediumNumber) && ej31.validarRang(minNumber) && ej31.validarRang(maxNumber);

            // Assert
            Assert.IsTrue(isInRange);
        }

        [TestMethod]
        public void NúmeroRandomGeneradoFueraDelRango()
        {
            // Arrange
            Random random = new();
            int randomNum = ej31.generarRandom(random);
            bool isInRange;

            // Act
            isInRange = randomNum >= 1 && randomNum <= 100;

            // Assert
            Assert.IsTrue(isInRange);
        }
    }
}