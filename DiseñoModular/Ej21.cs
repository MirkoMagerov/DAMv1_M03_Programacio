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
        public static void Main()
        {
            const string MsgLatinNumber = "Introduce un número latino para convertirlo a número entero: ";

            string userNumber;

            Console.Write(MsgLatinNumber);
            userNumber = Console.ReadLine().ToUpper().Replace(" ", "");

            Console.WriteLine(LatinNumberConverter(userNumber));
        }

        public static int LatinNumberConverter(string latinNumber)
        {
            const char LetterLatinI = 'I', LetterLatinV = 'V', LetterLatinX = 'X', LetterLatinL = 'L', LetterLatinC = 'C', LetterLatinD = 'D', LetterLatinM = 'M';
            const int NumLatinI = 1, NumLatinV = 5, NumLatinX = 10, NumLatinL = 50, NumLatinC = 100, NumLatinD = 500, NumLatinM = 1000;

            int[] latinNumberArray = new int[latinNumber.Length];
            int result = 0;

            if (latinNumber != null)
            {
                for (int i = 0; i < latinNumberArray.Length; i++)
                {
                    int actualNumber = latinNumber[i] switch
                    {
                        LetterLatinI => NumLatinI,
                        LetterLatinV => NumLatinV,
                        LetterLatinX => NumLatinX,
                        LetterLatinL => NumLatinL,
                        LetterLatinC => NumLatinC,
                        LetterLatinD => NumLatinD,
                        LetterLatinM => NumLatinM,
                        _ => 0,
                    };
                    latinNumberArray[i] = actualNumber;
                }

                for (int i = 0; i < latinNumberArray.Length - 1; i++)
                {
                    if (i < latinNumberArray.Length)
                    {
                        if (latinNumberArray[i] < latinNumberArray[i + 1])
                        {
                            result += latinNumberArray[i + 1] - latinNumberArray[i];
                        }
                        else
                        {
                            result += latinNumberArray[i];
                        }
                    }
                }
            }

            return result;
        }
    }
}