using System;

namespace VehicleOOP
{
    public class Truck : Vehicle
    {
        private string? type;
        private int tones;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Tones
        {
            get { return tones; }
            set { tones = value; }
        }

        public bool IsHeavy(int tones)
        {
            return tones > 15;
        }

        public bool IsOlder(int year)
        {
            return year < 2005;
        }
    }
}