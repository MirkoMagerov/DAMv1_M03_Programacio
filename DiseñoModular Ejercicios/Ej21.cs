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
            const string MsgLatinNumber = "Introduce un número latino para convertirlo a número entero: ";

            string userNumber;

            Console.Write(MsgLatinNumber);
            userNumber = Console.ReadLine() ?? "".ToUpper();

            Console.WriteLine(LatinNumberConverter(userNumber));
        }

        public static int LatinNumberConverter(string number)
        {
            int result;



            return result;
        }
    }
}