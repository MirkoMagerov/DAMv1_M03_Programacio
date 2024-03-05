using System;

namespace Figuras
{
    public class Colour
    {
        const string DEFAULT_NAME = "No name";
        const int MIN_VALUE = 0, MAX_VALUE = 255;

        private static int counter = 0;

        public Colour(string name, int red, int green, int blue)
        {
            Name = name;
            Red = red;
            Green = green;
            Blue = blue;
            counter++;
        }

        public Colour(int red, int green, int blue) : this(DEFAULT_NAME, red, green, blue) { }

        public Colour(int red, int green) : this(DEFAULT_NAME, red, green, MIN_VALUE) { }

        public Colour(int red) : this(DEFAULT_NAME, red, MIN_VALUE, MIN_VALUE) { }

        public Colour() : this(DEFAULT_NAME, MAX_VALUE, MAX_VALUE, MAX_VALUE) { }

        public string Name { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public static int Counter { get { return counter; } }

        public string GetRGB(bool mayus)
        {
            return (mayus ? "RGB" : "rgb") + $":({Red}, {Green}, {Blue})";
        }

        public string GetRGB() => GetRGB(false);

        public string GetHex()
        {
            const int HEX_CONVERTER = 16;

            string[] HEXADECIMAL_VALUES = [ "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"];

            string[] hexadecimal_value = new string[6];

            for (int i = 0; i < hexadecimal_value.Length / 2; i++)
            {
                int actColor = 0;

                switch (i)
                {
                    case 0: actColor = Red; break;
                    case 1: actColor = Green; break;
                    case 2: actColor = Blue; break;
                }

                int firstDiv = actColor / HEX_CONVERTER;
                int secondDiv = actColor % HEX_CONVERTER;

                hexadecimal_value[i * 2] = HEXADECIMAL_VALUES[firstDiv];                
                hexadecimal_value[i*2 +1] = HEXADECIMAL_VALUES[secondDiv];
            }

            string hex = "";
            foreach (string value in hexadecimal_value)
            {
                hex += value;
            }
            return hex;
        }
    }
}
