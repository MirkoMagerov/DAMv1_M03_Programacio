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
        // CÓDIGO MAIN
        public static void Main()
        {
            const string MsgEnterNumber = "Introduce un número decimal para separar la parte entera de la parte decimal: ";

            double userNumber;

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToDouble(Console.ReadLine());

            GetNaturalPart(userNumber);
        }

        public static void GetNaturalPart(double number)
        {
            int enterNumber = Convert.ToInt32(Math.Truncate(number));
            double decimalNumber = Math.Round(number - enterNumber, 3);

            Console.WriteLine("Número sin parte decimal: " + enterNumber);
            Console.WriteLine("Número sólo con los decimales: " + decimalNumber);
        }
    }
}