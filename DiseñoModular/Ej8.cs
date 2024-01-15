/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 8.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const int RandomNumbersArray = 10, MinNumber = 0, MaxNumber = 257;

            int[] randomNumbersArray = new int[RandomNumbersArray];

            for (int i = 0; i < randomNumbersArray.Length; i++)
            {
                randomNumbersArray[i] = new Random().Next(MinNumber, MaxNumber);
            }

            for (int i = 0; i < randomNumbersArray.Length; i++)
            {
                Console.Write(randomNumbersArray[i] + " ");
            }
        }
    }
}