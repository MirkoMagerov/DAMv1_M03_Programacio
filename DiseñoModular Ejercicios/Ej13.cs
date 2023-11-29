/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 13.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgActualNumber = "Número actual: ";
            const string MsgEnterNumbers = "Introduce un número: ";

            const int ArraySize = 20;

            int[] numbersArray = new int[ArraySize];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine(MsgActualNumber + (i + 1));
                Console.Write(MsgEnterNumbers);
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            PrintOddPositions(numbersArray);
        }

        public static void PrintOddPositions(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}