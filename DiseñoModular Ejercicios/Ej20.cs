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
        // C�DIGO MAIN
        public static void Main()
        {
            const string MsgEnterNumber = "Introduce un n�mero decimal para separar la parte entera de la parte decimal: ";

            double userNumber;

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToDouble(Console.ReadLine());

            GetNaturalPart(userNumber);
        }

        public static void GetNaturalPart(double number)
        {
            int enterNumber = Convert.ToInt32(Math.Truncate(number));
            double decimalNumber = Math.Round(number - enterNumber, 3);

            Console.WriteLine("N�mero sin parte decimal: " + enterNumber);
            Console.WriteLine("N�mero s�lo con los decimales: " + decimalNumber);
        }
    }
}