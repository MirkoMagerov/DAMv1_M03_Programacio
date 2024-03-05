using System;

namespace Figuras
{
    public class Circle : AFigura
    {
        public Circle(double radio, Colour foreColor, Colour bgColour)
        {
            Radius = radio;
            ForeColour = foreColor;
            BgColour = bgColour;
        }

        public override double CalulateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public override string GetForeColor() => ForeColour.Name;

        public override string GetBgColor() => BgColour.Name;
    }
}
