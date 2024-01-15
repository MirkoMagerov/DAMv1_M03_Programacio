/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici Modular - Heroes vs Monster.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        public static void Main()
        {
            const string MsgEnterNumber = "Introduce el número que tendrá que adivinar el ordenador (1 ... 100) : ";

            string userAproximation;
            bool numberSolved = false;
            int userNumber, tries = 10, minIANum = 1, maxIANum = 100, computerGuess;

            Random random = new();

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToInt32(Console.ReadLine());

            do
            {
                computerGuess = ComputerGuess(random, minIANum, maxIANum);

                Console.WriteLine($"El ordenador ha elegido el número {computerGuess}.");
                Console.WriteLine();

                if (userNumber == computerGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡El ordenador ha adivinado el número!");
                    Console.ResetColor();
                    numberSolved = true;
                }

                else
                {
                    userAproximation = GetUserAproximation();
                    Console.WriteLine();
                    UpdateValidRange(ref minIANum, ref maxIANum, userAproximation, computerGuess);
                    tries--;
                }

            } while (tries > 0 && !numberSolved);

            if (tries == 0)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("El ordenador se ha quedado sin intentos");
                Console.WriteLine("***************************************");
            }
        }

        public static int ComputerGuess(Random random, int minValue, int maxValue)
        {
            return random.Next(minValue, GetMaxValue(maxValue));
        }

        public static int GetMaxValue(int num)
        {
            return num + 1;
        }

        public static string GetUserAproximation()
        {
            bool validWord;
            string word;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("El ordenador no ha adivinado el número. Ayudale escribiendo 'bigger' si el número que tiene que\nadivinar es mayor o 'smaller' si el número a adivinar és menor.\nTu respuesta: ");
                Console.ResetColor();
                word = Console.ReadLine() ?? "".Trim().ToLower();

                if (word == "bigger" || word == "smaller")
                {
                    validWord = true;
                }
                else
                {
                    validWord = false;
                }

            } while (!validWord);

            return word;
        }

        public static void UpdateValidRange(ref int minValue, ref int maxValue, string userAproximation, int computerGuess)
        {
            if (userAproximation == "smaller")
            {
                maxValue = computerGuess - 1;
            }
            else
            {
                minValue = computerGuess + 1;
            }
        }
    }
}