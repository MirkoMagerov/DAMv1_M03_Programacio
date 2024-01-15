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
        public static void Main()
        {
            const string MsgEnterNumber = "Escribe el n�mero para calcular si es un n�mero primero: ";

            int number, divisibleNumberTest = 2;

            Console.Write(MsgEnterNumber);
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrimeNumber(number, divisibleNumberTest) ? "Es n�mero primo" : "No es n�mero primo");
        }

        public static bool IsPrimeNumber(int number, int divisibleNumberTest)
        {
            if (divisibleNumberTest == number || number == 1) return true;

            else if (number % divisibleNumberTest == 0) return false;

            else return IsPrimeNumber(number, divisibleNumberTest + 1);
        }
    }
}