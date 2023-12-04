/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 14.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un n�mero: ";
            const string MsgDigitsNumber = "La cantidad de d�gitos que tiene el n�mero es: ";
            const string MsgOddDigitsSum = "La suma de los d�gitos impares es: ";
            const string MsgEvenDigitsSum = "La suma de los d�gitos pares es: ";

            int userNumber;

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgDigitsNumber + CalculateDigits(userNumber));
            Console.WriteLine(MsgOddDigitsSum + SumDigits(userNumber, 0));
            Console.WriteLine(MsgEvenDigitsSum + SumDigits(userNumber, 1));
        }

        // Calcular n�mero d�gitos
        public static int CalculateDigits(int number)
        {
            int digits = 1;

            number /= 10;

            while (number > 0)
            {
                number /= 10;
                digits++;
            }

            return digits;
        }

        // Sumar los d�gitos dependiendo la posici�n

        public static int SumDigits(int number, int expectedResult)
        {
            int sumDigits = 0;

            do
            {
                if (number % 10 % 2 == expectedResult)
                {
                    sumDigits += number % 10;
                }
                number /= 10;

            } while (number > 0);

            return sumDigits;
        }
    }
}