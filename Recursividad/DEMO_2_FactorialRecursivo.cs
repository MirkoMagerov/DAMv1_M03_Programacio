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
            const string MsgEnterNumber = "Introduce el número para hacer el factorial: ";

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