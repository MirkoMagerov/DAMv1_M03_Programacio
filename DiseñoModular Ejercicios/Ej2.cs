/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 2.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgBaseNumber = "Introduce la base: ";
            const string MsgExpNumber = "Introduce el exponente: ";

            int baseNumber, expNumber;

            do
            {
                Console.Write(MsgBaseNumber);
                baseNumber = Convert.ToInt32(Console.ReadLine());

            } while (WithoutDecimals(baseNumber));

            do
            {
                Console.Write(MsgExpNumber);
                expNumber = Convert.ToInt32(Console.ReadLine());

            } while (WithoutDecimals(expNumber));

            Exponentiation(baseNumber, expNumber);
        }

        public static bool WithoutDecimals(int number)
        {
            if (number % 1 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Exponentiation(float baseNumber, float expNumber)
        {
            float number = 1;

            if (expNumber != 0)
            {
                if (expNumber > 0)
                {
                    for (int i = 0; i < expNumber; i++)
                    {
                        number *= baseNumber;
                    }
                }
                else
                {
                    for (int i = ((int)expNumber); i < 0; i++)
                    {
                        number /= baseNumber;
                    }
                }
            }

            Console.WriteLine($"La poténcia de la base {baseNumber}^{expNumber} es {number}.");
        }
    }
}