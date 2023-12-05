/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 17.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        public static void Main()
        {
            const string MsgEnterTemperatureCº = "Introduce una temperatura en Celsius para pasarlos a Fahrenheit: ";
            const string MsgFinalAnswer = "La temperatura convertida a Fahrenheit es: ";


            double celsius;

            Console.Write(MsgEnterTemperatureCº);
            celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(MsgFinalAnswer + CelsiusToFahrenheit(celsius));
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            const int MultipliedBy = 9, DividedBy = 5, SumBy = 32;
            return Math.Round((celsius * MultipliedBy / DividedBy) + SumBy, 2);
        }
    }
}