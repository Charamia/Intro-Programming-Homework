using System;


namespace QuadraticEquation
{
    class StartUp
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double diskriminanta = Math.Pow(b, 2) - (4 * a * c);
            double x1 = -b / (2 * a);
            double x2 = (-b + Math.Sqrt(diskriminanta)) / (2 * a);
            double x3 = (-b - Math.Sqrt(diskriminanta)) / (2 * a);
            
            if (diskriminanta < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if(diskriminanta == 0)
            {
                Console.WriteLine("{0:0.00}", x1);
            }
            else if(diskriminanta >0)
            {
                Console.WriteLine("{0:0.00}",x3);
                Console.WriteLine("{0:0.00}",x2);
            }
        }
    }
}
