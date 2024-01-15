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
            const string MsgEnterNumber = "Introduce el n�mero para hacer el factorial: ";

            Console.Write(MsgEnterNumber);
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecursividadFactorial(num));
        }

        public static int RecursividadFactorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * RecursividadFactorial(num - 1);
            }
        }
    }
}