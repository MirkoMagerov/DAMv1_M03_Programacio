using System;

namespace Figuras
{
    public class Program
    {
        public static void Main()
        {
            MirkoMath mirkoMath = new();

            Colour firstRandomColor = new Colour("RandomOne", mirkoMath.NextIncluded(255), mirkoMath.NextIncluded(255), mirkoMath.NextIncluded(255));
            Console.WriteLine(Colour.Counter);

            Colour secondRandomColor = new Colour("RandomTwo", mirkoMath.NextIncluded(255), mirkoMath.NextIncluded(255), mirkoMath.NextIncluded(255));
            Console.WriteLine(Colour.Counter);

            Colour thirRandomColor = new Colour("RandomThree", mirkoMath.NextIncluded(255), mirkoMath.NextIncluded(255), mirkoMath.NextIncluded(255));
            Console.WriteLine(Colour.Counter);

            Circle circle = new Circle(3.46, firstRandomColor, secondRandomColor);
            Square square = new Square(2.5, secondRandomColor, thirRandomColor);
            Triangle triangle = new Triangle(2.5, 3.7, thirRandomColor, firstRandomColor);

            Console.WriteLine(circle.GetForeColor());
            Console.WriteLine(circle.GetBgColor());

            Console.WriteLine();

            Console.WriteLine(square.GetForeColor());
            Console.WriteLine(square.GetBgColor());

            Console.WriteLine();

            Console.WriteLine(triangle.GetForeColor());
            Console.WriteLine(triangle.GetBgColor());

            Console.WriteLine(firstRandomColor.GetRGB(true));
            Console.WriteLine(firstRandomColor.GetRGB());

            Colour hex = new Colour(220, 220, 150);
            Console.WriteLine(hex.GetHex());
        }
    }
}