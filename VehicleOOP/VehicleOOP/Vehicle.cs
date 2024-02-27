using System;

namespace VehicleOOP
{
    public class Vehicle
    {
        protected string? brand;
        protected string? model;
        protected string? licensePlate;
        protected int wheels;
        protected int year;
        protected float kms;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public float Kms
        {
            get { return kms; }
            set { kms = value; }
        }

        public bool IsOlder(int year)
        {
            return year < 2005;
        }
    }
}