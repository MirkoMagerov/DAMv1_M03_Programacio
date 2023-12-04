/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 15.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterYear = "Introduce un a�o para saber si es bisiesto: ";
            const string MsgLeapYear = "El a�o que has introducido es un a�o bisiesto.";
            const string MsgNotLeapYear = "El a�o que has introducido no es un a�o bisiesto.";

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