/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 9.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un n�mero: ";
            const string MsgEnterSecondNumber = "Introduce un n�mero para saber si el primero es menor que este: ";
            const string MsgEnterThirdNumber = "Introduce un n�mero para verificar si el primer n�mero esta dentro del rango del seguno y de este ultimo: ";
            const string MsgFirstNumberLower = "El primer n�mero es m�s peque�o que el segundo.";
            const string MsgFirstNumberBigger = "El primer n�mero es m�s grande que el segundo.";
            const string MsgFirstNumberBetween = "El primer n�mero se encuentra entre los otros dos n�meros.";
            const string MsgFirstNumberNotBetween = "El primer n�mero no se encuentra entre los otros dos n�meros.";

            float userNumber, secondNumber, thirdNumber;

            Console.Write(MsgEnterNumber);
            userNumber = Convert.ToSingle(Console.ReadLine());

            Console.Write(MsgEnterSecondNumber);
            secondNumber = Convert.ToSingle(Console.ReadLine());

            Console.Write(MsgEnterThirdNumber);
            thirdNumber = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(ValidateNumber(userNumber, secondNumber) ? MsgFirstNumberLower : MsgFirstNumberBigger);

            Console.WriteLine();

            Console.WriteLine(ValidateNumber(userNumber, secondNumber, thirdNumber) ? MsgFirstNumberBetween : MsgFirstNumberNotBetween);
        }

        public static bool ValidateNumber(float entryNumber, float validationNumber)
        {
            return entryNumber < validationNumber ? true : false;
        }

        public static bool ValidateNumber(float entryNumber, float lowerNumber, float biggerNumber)
        {
            return entryNumber > lowerNumber && entryNumber < biggerNumber ? true : false;
        }
    }
}