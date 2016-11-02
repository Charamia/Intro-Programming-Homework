using System;


namespace ThirdBit
{
    class Startup
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            int constanta = 3;
            uint mask = 1 << 3;
            uint number2 = number & mask;
            uint bit = number2 >> constanta;
            Console.WriteLine(bit);
               
        }
    }
}
