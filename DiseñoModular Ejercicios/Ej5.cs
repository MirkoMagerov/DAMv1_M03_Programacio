/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 5.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un número: ";
            const string MsgPositiveUnder100 = "El número es positivo y menor que 100.";
            const string MsgOtherCaseNumber = "El número no es positivo o no es menor que 100.";

            float userNumber;

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(Method(userNumber, MsgPositiveUnder100, MsgOtherCaseNumber));
        }

        static public string Method(float number, string positiveCase, string negativeCase)
        {
            return number >= 0 && number < 100 ? positiveCase : negativeCase;
        }
    }
}