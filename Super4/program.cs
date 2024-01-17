using System;

namespace Project
{
    public class MyClass
    {
        public static void Main()
        {
            const int MIN_LENGTH = 2, MAX_LENGTH = 25, MIN_LEVEL = 1000, MAX_LEVEL = 50000, MIN_OPTION = 1, MAX_OPTION = 4;
            const string MSG_GET_CHAR = "Escribe el personaje que quieres (1 .. 4): ";
            const string MSG_GET_NAME = "Ingresa el nombre del personaje malvado (Desde 2 hasta 25 carácteres): ";

            char[] specialChars = { '$', '%', '.', ',', '|', '!' };
            char[] VOWELS = { 'A', 'E', 'I', 'O', 'U' };

            string charName;
            int actualChar;
            double evilLevel;

            do
            {
                Console.Write(MSG_GET_CHAR);
                actualChar = Convert.ToInt32(Console.ReadLine());

            } while (!IsValidOption(actualChar, MIN_OPTION, MAX_OPTION));
        }

        public static bool CheckLength(int length, int MIN_LENGTH, int MAX_LENGTH)
        {
            return length >= MIN_LENGTH && length <= MAX_LENGTH;
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

        public static bool IsValidEvilLevel(int level, int MIN_LEVEL, int MAX_LEVEL)
        {
            return level >= MIN_LEVEL && level <= MAX_LEVEL;
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

        public static bool IsValidOption(int option, int MIN_OPTION, int MAX_OPTION)
        {
            return option >= MIN_OPTION && option <= MAX_OPTION;
        }

        public static double DistributeEvilLevel(bool containsTwoVowels, int totalEvilLevel, int numberOfCharacters)
        {
            const int DECIMAL_ROUND_NUMBER = 2, ONE_HUNDRED = 100, FIVE_PERCENT_NUMBER = 5;
            if (containsTwoVowels)
            {
                return Math.Round(Convert.ToDouble(totalEvilLevel) / numberOfCharacters, DECIMAL_ROUND_NUMBER);
            }
            else
            {
                return Math.Round(Convert.ToDouble(totalEvilLevel / ONE_HUNDRED * FIVE_PERCENT_NUMBER) / numberOfCharacters, DECIMAL_ROUND_NUMBER);
            }
        }

        public static void AssignMagicToFriends(double magicLevel, ref double char1Magic, ref double char2Magic, ref double char3Magic, ref double char4Magic)
        {
            char1Magic = magicLevel;
            char2Magic = magicLevel;
            char3Magic = magicLevel;
            char4Magic = magicLevel;

            Console.Write(magicLevel);
        }
    }
}