using System;


namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());

            double epc = Math.Abs(a - b);
            bool  areEqual = epc < 0.000001;
            Console.WriteLine(areEqual.ToString().ToLower());
        }
    }
}
