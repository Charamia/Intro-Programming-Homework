using System;


namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float weightOnTheEarth = float.Parse(Console.ReadLine());
            float weightOnTheMoon = weightOnTheEarth * 0.17f;
            Console.WriteLine("{0:0.000}", weightOnTheMoon);
        }
    }
}