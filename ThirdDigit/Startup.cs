using System;


namespace ThirdDigit
{
    class Startup
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int result = ((N / 100) % 10);
            if (result == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", result);
            }
        }
    }
}