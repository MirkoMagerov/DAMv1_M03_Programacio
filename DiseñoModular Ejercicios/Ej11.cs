/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 11.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un número natural para saber su factorial: ";

            int number;

            Console.Write(MsgEnterNumber);
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetFactorial(number));
        }

        public static float GetFactorial(int number)
        {
            int result = 1;

            if (number > 0)
            {
                for (int i = 1; i < number; i++)
                {
                    result *= i;
                }

                return result;
            }

            else if (number == 0)
            {
                return result;
            }

            else
            {
                return 0;
            }
        }
    }
}