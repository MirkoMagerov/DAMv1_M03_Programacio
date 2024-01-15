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
            const string MsgEnterBase = "Introduce la base: ";
            const string MsgEnterExp = "Introduce el exponente: ";

            Console.Write(MsgEnterBase);
            int baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgEnterExp);
            int expNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(RecursividadFactorial(baseNum, expNum));
        }

        public static int RecursividadFactorial(int baseNum, int expNum)
        {
            if (expNum == 0)
            {
                return 1;
            }
            else
            {
                return baseNum * RecursividadFactorial(baseNum, expNum - 1);
            }
        }
    }
}