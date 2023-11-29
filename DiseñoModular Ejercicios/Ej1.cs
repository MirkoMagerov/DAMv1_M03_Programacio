/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 1.
*/

namespace Proyecto
{
    public class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgFirstNumber = "Introduce el primer n�mero: ";
            const string MsgSecondNumber = "Introduce el segundo n�mero: ";
            const string MsgWrongNumber = "Debes introducir un n�mero natural. Prueba otra vez.";
            const string MsgEqualNumbers = "Los n�meros introducidos s�n los mismos.";
            const string MsgFirstBiggerNumber = "El primer n�mero �s mayor que el segundo.";
            const string MsgSecondBiggerNumber = "El segundo n�mero �s mayor que el primero.";

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


        // VALIDAR N�MEROS NATURALES
        public static bool ValidateNaturalNumber(int number)
        {
            return number <= 0;
        }


        // VERIFICAR QUE N�MERO ES M�S GRANDE O SI AMBOS SON IGUALES
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