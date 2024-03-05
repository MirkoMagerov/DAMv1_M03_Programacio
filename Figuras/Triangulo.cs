using System;

namespace Figuras
{
    public class Triangle : AFigura
    {
        public Triangle(double heigth, double width, Colour foreColor, Colour bgColour)
        {
            Heigth = heigth;
            Width = width;
            ForeColour = foreColor;
            BgColour = bgColour;
        }

        public override double CalulateArea()
        {
            return Heigth * Width / 2;
        }

        public override string GetForeColor() => ForeColour.Name;

        public override string GetBgColor() => BgColour.Name;
    }
}
