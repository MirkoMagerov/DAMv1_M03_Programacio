using System;

namespace VehicleOOP
{
    public class Motorbike : Vehicle
    {
        private int cubicCentimeters;
        private bool sidecar;

        public int CubicCentimeters
        {
            get { return cubicCentimeters; }
            set { cubicCentimeters = value; }
        }

        public bool Sidecar
        {
            get { return sidecar; }
            set { sidecar = value; }
        }

        public bool IsSidecar(bool sidecar)
        {
            return sidecar;
        }

        public bool IsOlder(int year)
        {
            return year < 2005;
        }
    }
}