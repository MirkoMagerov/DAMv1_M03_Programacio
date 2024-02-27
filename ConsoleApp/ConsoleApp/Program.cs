using System;

namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Car car1 = new Car(0);

            Console.Write("Introduce la cantidad para repostar: ");
            int fuel = Convert.ToInt32(Console.ReadLine());

            car1.Refuel(fuel);

            car1.Drive();
        }
    }
}