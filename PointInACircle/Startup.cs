using System;


namespace PointInACircle
{
    class Startup
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double min = -1000;
            double max = 1000;

            double circleRadius = 2;
            double Distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double SecondCircleArea = Math.PI * Math.Pow(Distance, 2);
            double circleArea = Math.PI * Math.Pow(circleRadius, 2);

            if (SecondCircleArea <= circleArea)
            {
                Console.WriteLine("yes " + "{0:F2}", Distance);
            }
            else
            {
                Console.WriteLine("no " + "{0:F2}", Distance);
            }
        }
    }
}
