/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 5.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un n�mero: ";
            const string MsgPositiveUnder100 = "El n�mero es positivo y menor que 100.";
            const string MsgOtherCaseNumber = "El n�mero no es positivo o no es menor que 100.";

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