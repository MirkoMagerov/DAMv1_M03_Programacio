/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 12.
*/

using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un número: ";

            int userNumber;

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateDigits(userNumber));
            Console.WriteLine(SumEvenDigits(userNumber));
            Console.WriteLine(SumOddDigits(userNumber));
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

        // Sumar dígitos con valor par
        public static int SumEvenDigits(int number)
        {
            int sumDigits = 0;

            do
            {
                if ((number - (number / 10)) % 2 == 0)
                {
                    sumDigits += number - number / 10;
                }
                number /= 10;

            } while (number > 0);

            return sumDigits;
        }

        // Sumar dígitos con valor impar
        public static int SumOddDigits(int number)
        {
            int sumDigits = 0;

            do
            {
                if ((number - (number / 10)) % 2 == 1)
                {
                    sumDigits += number - number / 10;
                }
                number /= 10;

            } while (number > 0);

            return sumDigits;
        }
    }
}