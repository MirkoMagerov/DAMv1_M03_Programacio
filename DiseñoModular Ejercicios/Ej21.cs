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
            const string MsgLatinNumber = "Introduce un n�mero latino para convertirlo a n�mero entero: ";

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