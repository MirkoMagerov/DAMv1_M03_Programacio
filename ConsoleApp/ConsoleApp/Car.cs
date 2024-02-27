using System;

namespace OOP
{
    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int startingFuel)
        {
            Fuel = startingFuel;
        }

        public void Drive()
        {
            Console.WriteLine(Fuel > 0 ? "Driving" : "The car doesn't have fuel.");
        }

        public bool Refuel(int fuel)
        {
            Fuel += fuel;
            return true;
        }
    }
}
