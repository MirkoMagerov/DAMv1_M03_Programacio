/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 12.
*/

using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un n�mero: ";

            int userNumber;

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateDigits(userNumber));
            Console.WriteLine(SumEvenDigits(userNumber));
            Console.WriteLine(SumOddDigits(userNumber));
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

        // Sumar d�gitos con valor par
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

        // Sumar d�gitos con valor impar
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