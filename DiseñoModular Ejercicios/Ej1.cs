/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 1.
*/

namespace Proyecto
{
    public class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgFirstNumber = "Introduce el primer número: ";
            const string MsgSecondNumber = "Introduce el segundo número: ";
            const string MsgWrongNumber = "Debes introducir un número natural. Prueba otra vez.";
            const string MsgEqualNumbers = "Los números introducidos són los mismos.";
            const string MsgFirstBiggerNumber = "El primer número és mayor que el segundo.";
            const string MsgSecondBiggerNumber = "El segundo número és mayor que el primero.";

            int firstNum, secondNum;

            bool secondExecution = false;

            do
            {
                if (secondExecution)
                {
                    Console.Write(MsgWrongNumber);
                }

                Console.Write(MsgFirstNumber);
                firstNum = Convert.ToInt32(Console.ReadLine());

                secondExecution = true;

            } while (ValidateNaturalNumber(firstNum));

            secondExecution = false;

            do
            {
                if (secondExecution)
                {
                    Console.Write(MsgWrongNumber);
                }

                Console.Write(MsgSecondNumber);
                secondNum = Convert.ToInt32(Console.ReadLine());

                secondExecution = true;

            } while (ValidateNaturalNumber(secondNum));

            switch (GetBiggerNumber(firstNum, secondNum))
            {
                case 0:
                    Console.WriteLine(MsgEqualNumbers);
                    break;

                case 1:
                    Console.WriteLine(MsgFirstBiggerNumber);
                    break;

                case 2:
                    Console.WriteLine(MsgSecondBiggerNumber);
                    break;
            }
        }


        // VALIDAR NÚMEROS NATURALES
        public static bool ValidateNaturalNumber(int number)
        {
            return number <= 0;
        }


        // VERIFICAR QUE NÚMERO ES MÁS GRANDE O SI AMBOS SON IGUALES
        public static int GetBiggerNumber(int firstNum, int secondNum)
        {
            if (firstNum == secondNum)
            {
                return 0;
            }

            else if (firstNum > secondNum)
            {
                return 1;
            }

            else
            {
                return 2;
            }
        }
    }
}