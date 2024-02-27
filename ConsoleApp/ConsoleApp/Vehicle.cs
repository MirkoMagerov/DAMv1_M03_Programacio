using System;

namespace ConsoleApp
{
    public class Vehicle
    {
        private string type; // Terrestre, marítimo, aéreo
        private string name;
    }

    public class Boat : Vehicle

    {
        private double speed;
    }

    public class WheeledVehicle : Vehicle
    {
        private int numberOfWheels;
        private int numberOfGears;
    }

    public class Bike : WheeledVehicle
    {
        private string typeOfBike;
    }
}