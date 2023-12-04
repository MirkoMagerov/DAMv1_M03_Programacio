/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 1.
*/

namespace Refactoring
{
    class FirstRefactoringExercise
    {
        static void Main()
        {
            const string MsgEnterQuantityNumbers = "Indica quants valors vols introduir: ";
            const string MsgEnterNumber = "Introdueix un valor entre el 5 i el 150 (inclosos). Tens 3 intents com a màxim: ";
            const string MsgWrongValue = "El valor introduït no és vàlid.";
            const string MsgMaxTriesReached = "Has superat el total d'intents.";
            const int MaxTries = 3, MinValue = 5, MaxValue = 150;

            int quantity, input, errors = 0, result = 1, actualIndex = 0;

            Console.Write(MsgEnterQuantityNumbers);
            quantity = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(MsgEnterNumber);
                input = Convert.ToInt32(Console.ReadLine());

                if (NumberInRange(input, MinValue, MaxValue))
                {
                    result *= input;
                    actualIndex++;
                }
                else
                {
                    Console.WriteLine(MsgWrongValue);
                    errors++;
                }

            } while (errors < MaxTries && actualIndex < quantity);

            Console.WriteLine(errors == 3 ? MsgMaxTriesReached : result);
        }

        public static bool NumberInRange(int number, int MinRange, int MaxRange)
        {
            if (number >= MinRange && number <= MaxRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}