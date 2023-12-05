/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 9.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un número: ";
            const string MsgEnterSecondNumber = "Introduce un número para saber si el primero es menor que este: ";
            const string MsgEnterThirdNumber = "Introduce un número para verificar si el primer número esta dentro del rango del seguno y de este ultimo: ";
            const string MsgFirstNumberLower = "El primer número es más pequeño que el segundo.";
            const string MsgFirstNumberBigger = "El primer número es más grande que el segundo.";
            const string MsgFirstNumberBetween = "El primer número se encuentra entre los otros dos números.";
            const string MsgFirstNumberNotBetween = "El primer número no se encuentra entre los otros dos números.";

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