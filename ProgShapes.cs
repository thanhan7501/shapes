using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class ProgShapes
    {
        public static void Run()
        {
            // get a circle
            Console.WriteLine("Enter circle's radius:");
            var radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);

            // get a rectangle
            Console.WriteLine("Enter rectangle's length:");
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rectangle's width:");
            var width = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(height, width);

            // draw shapes
            circle.Draw();
            rect.Draw();

            //Calculate Perimeter
            Console.WriteLine($"Circle perimeter: {circle.CalculatePerimeter()}");
            Console.WriteLine($"Rectangle perimeter:{rect.CalculatePerimeter()}");

            //Calculate Area
            Console.WriteLine($"Circle area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle area: {rect.CalculateArea()}");

            Console.ReadKey();
        }
    }
}
