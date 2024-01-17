using Project;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PersonajeEscogidoCorrectamente()
        {
            const int MIN_OPTION = 1, MAX_OPTION = 4;
            int option = 3;
            int option2 = 1;
            int option3 = 4;

            bool result1 = MyClass.CheckBetweenRange(option, MIN_OPTION, MAX_OPTION);
            bool result2 = MyClass.CheckBetweenRange(option2, MIN_OPTION, MAX_OPTION);
            bool result3 = MyClass.CheckBetweenRange(option3, MIN_OPTION, MAX_OPTION);

            Assert.IsTrue(result1 && result2 && result3);
        }

        [TestMethod]
        public void PersonajeEscogidoIncorrectamente_Superior()
        {
            const int MIN_OPTION = 1, MAX_OPTION = 4;
            int option = 5;

            bool result = MyClass.CheckBetweenRange(option, MIN_OPTION, MAX_OPTION);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PersonajeEscogidoIncorrectamente_Inferior()
        {
            const int MIN_OPTION = 1, MAX_OPTION = 4;
            int option = 0;

            bool result = MyClass.CheckBetweenRange(option, MIN_OPTION, MAX_OPTION);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LongitudAdecuada()
        {
            const int MIN_LENGTH = 2, MAX_LENGTH = 25;
            int wordLength = 10;
            int wordLength2 = 2;
            int wordLength3 = 25;

            bool result1 = MyClass.CheckBetweenRange(wordLength, MIN_LENGTH, MAX_LENGTH);
            bool result2 = MyClass.CheckBetweenRange(wordLength2, MIN_LENGTH, MAX_LENGTH);
            bool result3 = MyClass.CheckBetweenRange(wordLength3, MIN_LENGTH, MAX_LENGTH);

            Assert.IsTrue(result1 && result2 && result3);
        }

        [TestMethod]
        public void LongitudMayor()
        {
            const int MIN_LENGTH = 2, MAX_LENGTH = 25;
            int wordLength = 28;

            bool result = MyClass.CheckBetweenRange(wordLength, MIN_LENGTH, MAX_LENGTH);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LongitudMenor()
        {
            const int MIN_LENGTH = 2, MAX_LENGTH = 25;
            int wordLength = 1;

            bool result = MyClass.CheckBetweenRange(wordLength, MIN_LENGTH, MAX_LENGTH);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DobleVocal()
        {
            string name = "Bobo";
            char[] VOWELS = { 'A', 'E', 'I', 'O', 'U' };

            bool result = MyClass.ContainsTwoVowels(name.ToUpper(), VOWELS);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SinDobleVocal()
        {
            string name = "Adfghgf";
            char[] VOWELS = { 'A', 'E', 'I', 'O', 'U' };

            bool result = MyClass.ContainsTwoVowels(name, VOWELS);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidEvilLevel()
        {
            const int MIN_LEVEL = 1000, MAX_LEVEL = 50000;

            int evilLevel = 15000;

            bool result = MyClass.CheckBetweenRange(evilLevel, MIN_LEVEL, MAX_LEVEL);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NotValidEvilLevel_Higer()
        {
            const int MIN_LEVEL = 1000, MAX_LEVEL = 50000;

            int evilLevel = 70000;

            bool result = MyClass.CheckBetweenRange(evilLevel, MIN_LEVEL, MAX_LEVEL);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotValidEvilLevel_Lower()
        {
            const int MIN_LEVEL = 1000, MAX_LEVEL = 50000;

            int evilLevel = 500;

            bool result = MyClass.CheckBetweenRange(evilLevel, MIN_LEVEL, MAX_LEVEL);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasSpecialCharacters_True()
        {
            char[] specialChars = { '$', '%', '.', ',', '|', '!' };
            string name = "Bobo$";

            bool result = MyClass.HasSpecialCharacters(name, specialChars);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasSpecialCharacters_False()
        {
            char[] specialChars = { '$', '%', '.', ',', '|', '!' };
            string name = "Bobo";

            bool result = MyClass.HasSpecialCharacters(name, specialChars);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DivideBetweenFourWithTwoVowels()
        {
            bool containsTwoVowels = true;
            int numberOfCharacters = 4;
            double expected = 3750, result, totalEvilLevel = 15000;

            result = MyClass.CalculateMagicLevel(containsTwoVowels, totalEvilLevel, numberOfCharacters);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivideBetweenFourWithoutTwoVowels()
        {
            bool containsTwoVowels = false;
            int totalEvilLevel = 15000, numberOfCharacters = 4;
            double expected = 187.5;

            Assert.AreEqual(expected, MyClass.CalculateMagicLevel(containsTwoVowels, totalEvilLevel, numberOfCharacters));
        }

        [TestMethod]
        public void AssignMagicLevelToFriends()
        {
            string expected = "12,5";
            double magicLevel = 12.5, char1Magic = 0, char2Magic = 0, char3Magic = 0, char4Magic = 0;

            StringWriter sw = new();
            Console.SetOut(sw);
            MyClass.AssignMagicToFriends(magicLevel, ref char1Magic, ref char2Magic, ref char3Magic, ref char4Magic);

            Assert.IsTrue(sw.ToString().Contains(expected));
        }
    }
}