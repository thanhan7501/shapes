using System;

namespace Shapes
{
    class Rectangle : Shape
    {

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }

        public double Width { get; set; }

        public override void Draw()
        {
            DrawLine(Height, '*', '*');
            for (int i = 1; i < Width - 1; ++i)
            {
                DrawLine(Height, '*', ' ');
            }
            DrawLine(Height, '*', '*');
        }

        private void DrawLine(double width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}