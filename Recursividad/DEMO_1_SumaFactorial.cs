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
            const string MsgEnterNumber = "Introduce el n�mero para hacer la suma factorial: ";

            Console.Write(MsgEnterNumber);
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecursividadSuma(num));
        }

        public static int RecursividadSuma(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num + RecursividadSuma(num - 1);
            }
        }
    }
}