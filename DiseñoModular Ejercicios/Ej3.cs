/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 3.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un número para saber su valor absoluto: ";
            const string MsgAbsValue = "El valor absoluto del numero es:";

            float number;

            Console.Write(MsgEnterNumber);
            number = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{MsgAbsValue} {GetAbsValue(number)}");
        }

        static public float GetAbsValue(float number)
        {
            return number >= 0 ? number : -number;
        }
    }
}