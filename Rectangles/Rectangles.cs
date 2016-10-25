using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectangularArea = width * height;
            double rectangularPerimeter = (2 * width) + (2 * height);
            Console.WriteLine("{0:F2} {1:F2}", rectangularArea,  rectangularPerimeter);
        }
    }
}
