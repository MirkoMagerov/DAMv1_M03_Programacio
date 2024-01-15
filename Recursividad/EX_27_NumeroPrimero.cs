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
        public static void Main()
        {
            const string MsgEnterNumber = "Escribe el número para calcular si es un número primero: ";

            int number, divisibleNumberTest = 2;

            Console.Write(MsgEnterNumber);
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrimeNumber(number, divisibleNumberTest) ? "Es número primo" : "No es número primo");
        }

        public static bool IsPrimeNumber(int number, int divisibleNumberTest)
        {
            if (divisibleNumberTest == number || number == 1) return true;

            else if (number % divisibleNumberTest == 0) return false;

            else return IsPrimeNumber(number, divisibleNumberTest + 1);
        }
    }
}