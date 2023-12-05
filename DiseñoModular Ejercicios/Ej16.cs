/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici X.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main()
        {
            const string MsgQuantityNumbers = "Introduce cuantos valores quieres introducir: ";
            const string MsgEnterNumber = "Introduce un número para almacenar: ";
            const string MsgWrongValue = "El número no es correcto (fuera del rango). Vuelve a intentarlo.";
            const string MsgFinalResult = "El producto de todos los números que has introducido es: ";
            const int MinRange = 15, MaxRange = 100;

            bool secondExecution;

            int quantity, number, tries = 5, result = 1;

            Console.Write(MsgQuantityNumbers);
            quantity = Convert.ToInt32(Console.ReadLine());
            int[] numbersArray = new int[quantity];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (tries > 0)
                {
                    secondExecution = false;

                    do
                    {
                        if (secondExecution)
                        {
                            tries--;
                            Console.WriteLine(MsgWrongValue);
                        }

                        Console.Write(MsgEnterNumber);
                        number = Convert.ToInt32(Console.ReadLine());

                        secondExecution = true;

                    } while (NumberInRange(number, MinRange, MaxRange) && tries > 1);

                    numbersArray[i] = number;
                    result *= numbersArray[i];
                }
            }

            Console.WriteLine(MsgFinalResult + result);
        }

        public static bool NumberInRange(int number, int min, int max)
        {
            return number > min && number < max ? false : true;
        }
    }
}