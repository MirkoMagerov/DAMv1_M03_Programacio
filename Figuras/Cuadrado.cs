using System;

namespace Figuras
{
    public class Square : AFigura
    {
        public Square(double side, Colour foreColor, Colour bgColour)
        {
            Side = side;
            ForeColour = foreColor;
            BgColour = bgColour;
        }

        public override double CalulateArea()
        {
            return Side * Side;
        }

        public override string GetForeColor() => ForeColour.Name;

        public override string GetBgColor() => BgColour.Name;
    }
}
