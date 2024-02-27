using System;

namespace VehicleOOP
{
    public class Car : Vehicle
    {
        private int doors;
        private string? color;

        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool IsBig(int year)
        {
            return 2024 - year > 15;
        }

        public bool IsOlder(int year)
        {
            return year < 2005;
        }
    }
}