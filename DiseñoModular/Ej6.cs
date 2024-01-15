/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 6.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterNumber = "Introduce un n�mero para saber su valor absoluto: ";
            const string MsgAbsValue = "El valor absoluto del numero es:";

            float number;

            Console.Write(MsgEnterNumber);
            number = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{MsgAbsValue} {Math.Abs(number)}");
        }
    }
}