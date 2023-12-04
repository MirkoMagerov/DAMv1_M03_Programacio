/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 15.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterYear = "Introduce un año para saber si es bisiesto: ";
            const string MsgLeapYear = "El año que has introducido es un año bisiesto.";
            const string MsgNotLeapYear = "El año que has introducido no es un año bisiesto.";

            int year;

            Console.Write(MsgEnterYear);
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsBisiesto(year) ? MsgLeapYear : MsgNotLeapYear);
        }

        public static bool IsBisiesto(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}