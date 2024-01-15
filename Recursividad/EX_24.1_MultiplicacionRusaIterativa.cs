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
            const string MsgFirstNum = "Escribe el primer n�mero: ";
            const string MsgSecondNum = "Escribe el segundo n�mero: ";

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