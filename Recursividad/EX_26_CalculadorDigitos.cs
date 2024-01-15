/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici X.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        public static void Main()
        {
            const string MsgEnterNumber = "Escribe el n�mero para calcular la suma de sus d�gitos: ";

            int number, digitsSum = 0;

            Console.Write(MsgEnterNumber);
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DigitsCalculation(number, digitsSum));
        }

        public static int DigitsCalculation(int number, int digitsSum)
        {
            if (number == 0) return digitsSum;

            else
            {
                digitsSum += number % 10;
                number /= 10;
                return DigitsCalculation(number, digitsSum);
            }
        }
    }
}