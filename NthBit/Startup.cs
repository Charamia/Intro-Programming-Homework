using System;


namespace NthBit
{
    class Startup
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            long mask = 1 << position;
            long nAndMask = number & mask;
            long bit = nAndMask >> position;
            Console.WriteLine(bit);

        }
    }
}
