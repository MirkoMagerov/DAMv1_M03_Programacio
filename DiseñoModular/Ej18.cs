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
        // CÓDIGO MAIN
        public static void Main()
        {
            const string MsgMinute = "Introduce un número entero de minutos para pasarlo a segundos: ";
            const string MsgConvertedMinutes = "Los minutos que has introducido ({0}) pasados a segundos son {1} segundos.";

            int minute;

            Console.Write(MsgMinute);
            minute = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgConvertedMinutes, minute, MinutesToSecondsConverter(minute));
        }

        public static int MinutesToSecondsConverter(int minutes)
        {
            const int secondsPerMinute = 60;

            return minutes * secondsPerMinute;
        }
    }
}