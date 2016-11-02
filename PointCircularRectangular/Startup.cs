using System;


namespace PointCircularRectangular
{
    class Startup
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double radius = 1.5;
            double circleX = 1;
            double circleY = 1;
            if ((Math.Pow((circleX - x) + (circleY - y), 2)<= Math.Pow(radius,2)))
                {
                if(((x >= -1) && (x <= 5)) && ((y <= 1) && (y >= -1)))
                {
                    Console.WriteLine("inside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("inside circle outside rectangle");
                }
            }
            else
            {
                if(((x >= -1) && (x <= 5)) &&((y >= -1) && (y <= 1)))
                {
                    Console.WriteLine("outside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("outside circle outside rectangle");
                }
            }

        }

    }
}
