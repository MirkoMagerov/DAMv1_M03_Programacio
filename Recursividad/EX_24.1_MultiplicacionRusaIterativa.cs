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
            const string MsgFirstNum = "Escribe el primer número: ";
            const string MsgSecondNum = "Escribe el segundo número: ";

            int firstNum, secondNum;

            Console.Write(MsgFirstNum);
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgSecondNum);
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MultiplicacionRusa(firstNum, secondNum));
        }

        public static int MultiplicacionRusa(int firstNum, int secondNum)
        {
            int result = 0;

            if (firstNum % 2 != 0)
            {
                result += secondNum;
            }

            while (firstNum > 1)
            {
                firstNum /= 2;
                secondNum *= 2;

                if (firstNum % 2 != 0)
                {
                    result += secondNum;
                }
            }

            return result;
        }
    }
}