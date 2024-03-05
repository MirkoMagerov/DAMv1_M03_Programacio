using System;

namespace Figuras
{
    public abstract class AFigura
    {
        protected double Heigth {  get; set; }
        protected double Width { get; set; }
        protected double Side { get; set; }
        protected double Radius { get; set; }
        protected int NumberOfSides { get; set; }

        protected Colour? ForeColour { get; set; }
        protected Colour? BgColour { get; set; }

        public abstract double CalulateArea();

        public abstract string GetForeColor();
        public abstract string GetBgColor();
    }
}
