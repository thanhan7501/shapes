using System;

namespace Shapes
{
    class Circle : Shape
    {

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override void Draw()
        {
            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;
            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public override double CalculatePerimeter()
        {
            return 2 * Radius * Math.PI;
        }

        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}