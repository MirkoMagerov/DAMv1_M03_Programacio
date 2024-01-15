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
        public static void Main()
        {
            const double Degree180 = 180.0;

            Random random = new();

            bool positiveDegrees;

            double initialVelocity = 1.0, initialDirection = 45, totalSimulationTime = 5, changeDirectionInterval = 10;

            double radiantsDirection = Math.PI * initialDirection / Degree180;

            double initialVelocityX = initialVelocity * Math.Cos(radiantsDirection);
            double initialVelocityY = initialVelocity * Math.Sin(radiantsDirection);

            double posX = 0, posY = 0, actualTime = 1;

            while (actualTime <= totalSimulationTime)
            {
                Console.WriteLine($"Tiempo: {actualTime} s, Posición: ({posX}, {posY})");

                posX += initialVelocityX;
                posY += initialVelocityY;

                radiantsDirection = Math.PI * initialDirection / 180.0;

                positiveDegrees = GetNewDegreeDirection(random);



                actualTime++;
            }
        }

        public static bool GetNewDegreeDirection(Random random)
        {
            return random.Next(0, 2) == 0;
        }
    }
}