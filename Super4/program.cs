using System;

namespace Project
{
    public class MyClass
    {
        public static void Main()
        {
            const int MIN_LENGTH = 2, MAX_LENGTH = 25, MIN_LEVEL = 1000, MAX_LEVEL = 50000, MIN_OPTION = 1, MAX_OPTION = 4, NUMBER_OF_CHARACTERS = 4;
            const string MSG_GET_CHAR = "Escribe el personaje que quieres [ 1 .. 4 ]: ";
            const string MSG_GET_NAME = "Escribe el nombre del personaje malvado (Desde 2 hasta 25 carácteres): ";
            const string MSG_GET_EVIL_LEVEL = "Escribe el nivel de maldad del personaje [ 1000 .. 50000 ]: ";

            char[] specialChars = { '$', '%', '.', ',', '|', '!' };
            char[] VOWELS = { 'A', 'E', 'I', 'O', 'U' };

            string charName;
            int actualChar;
            double evilLevel, magicLevel, char1Magic = 0, char2Magic = 0, char3Magic = 0, char4Magic = 0, userCharEvilLevel;
            bool containsTwoVowels;

            do
            {
                Console.Write(MSG_GET_CHAR);
                actualChar = Convert.ToInt32(Console.ReadLine());

            } while (!CheckBetweenRange(actualChar, MIN_OPTION, MAX_OPTION));

            do
            {
                Console.Write(MSG_GET_NAME);
                charName = Console.ReadLine() ?? "".Trim().Replace(" ", "");

            } while (!CheckBetweenRange(charName.Length, MIN_LENGTH, MAX_LENGTH) || HasSpecialCharacters(charName, specialChars));

            do
            {
                Console.Write(MSG_GET_EVIL_LEVEL);
                evilLevel = Convert.ToDouble(Console.ReadLine());

            } while (!CheckBetweenRange(evilLevel, MIN_LEVEL, MAX_LEVEL));

            containsTwoVowels = ContainsTwoVowels(charName.ToUpper(), VOWELS);

            magicLevel = CalculateMagicLevel(containsTwoVowels, evilLevel, NUMBER_OF_CHARACTERS);

            AssignMagicToFriends(magicLevel, ref char1Magic, ref char2Magic, ref char3Magic, ref char4Magic);

            userCharEvilLevel = evilLevel - magicLevel * NUMBER_OF_CHARACTERS;
        }

        public static bool CheckBetweenRange(int range, int MIN_RANGE, int MAX_RANGE)
        {
            return range >= MIN_RANGE && range <= MAX_RANGE;
        }

        public static bool CheckBetweenRange(double range, int MIN_RANGE, int MAX_RANGE)
        {
            return range >= MIN_RANGE && range <= MAX_RANGE;
        }

        public static bool ContainsTwoVowels(string name, char[] vowels)
        {
            int vowelCounter = 0;
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (name[i] == vowels[j])
                    {
                        vowelCounter++;
                        if (vowelCounter == 2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool HasSpecialCharacters(string name, char[] specialCharacters)
        {
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < specialCharacters.Length; j++)
                {
                    if (name[i] == specialCharacters[j]) return true;
                }
            }
            return false;
        }

        public static double CalculateMagicLevel(bool containsTwoVowels, double totalEvilLevel, int numberOfCharacters)
        {
            const int DECIMAL_ROUND_NUMBER = 2, ONE_HUNDRED = 100, FIVE_PERCENT_NUMBER = 5;
            if (containsTwoVowels)
            {
                return Math.Round(totalEvilLevel / numberOfCharacters, DECIMAL_ROUND_NUMBER);
            }
            else
            {
                return Math.Round(totalEvilLevel / ONE_HUNDRED * FIVE_PERCENT_NUMBER / numberOfCharacters, DECIMAL_ROUND_NUMBER);
            }
        }

        public static void AssignMagicToFriends(double magicLevel, ref double char1Magic, ref double char2Magic, ref double char3Magic, ref double char4Magic)
        {
            char1Magic = magicLevel;
            char2Magic = magicLevel;
            char3Magic = magicLevel;
            char4Magic = magicLevel;

            Console.Write(char1Magic); // Solo para comprobar en el Unit Test que lo asigna correctamente con los decimales indicados.
        }
    }
}