using System;


namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            int chislo = int.Parse(Console.ReadLine());
            int position3;
            int position4;
            int position5;
            int mask1 = 24 << 3;
            int mask2 = 25 << 4;
            int mask3 = 26 << 5;
            int result = chislo | mask1;

        }
    }
}
