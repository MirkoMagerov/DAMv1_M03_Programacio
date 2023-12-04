/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 14.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un número: ";
            const string MsgDigitsNumber = "La cantidad de dígitos que tiene el número es: ";
            const string MsgOddDigitsSum = "La suma de los dígitos impares es: ";
            const string MsgEvenDigitsSum = "La suma de los dígitos pares es: ";

            int userNumber;

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgDigitsNumber + CalculateDigits(userNumber));
            Console.WriteLine(MsgOddDigitsSum + SumDigits(userNumber, 0));
            Console.WriteLine(MsgEvenDigitsSum + SumDigits(userNumber, 1));
        }

        // Calcular número dígitos
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

        // Sumar los dígitos dependiendo la posición

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