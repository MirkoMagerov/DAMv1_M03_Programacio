/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 7.
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

            Console.WriteLine(Math.Pow(baseNumber, expNumber));
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
    }
}