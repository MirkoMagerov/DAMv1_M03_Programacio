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
            const string MsgEnterNumber = "Escribe el número para pasarlo a binario: ";
            int decimalNum, binaryNum = 0, timesDivided = 1;

            Console.Write(MsgEnterNumber);
            decimalNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(BinaryRecursion(decimalNum, timesDivided, binaryNum));
        }

        public static int BinaryRecursion(int decimalNum, int timesDivided, int binaryNum)
        {
            if (decimalNum == 0)
            {
                return binaryNum;
            }

            else
            {
                binaryNum += decimalNum % 2 != 0 ? 1 * timesDivided : 0;

                timesDivided *= 10;
                decimalNum /= 2;
                return BinaryRecursion(decimalNum, timesDivided, binaryNum);
            }
        }
    }
}