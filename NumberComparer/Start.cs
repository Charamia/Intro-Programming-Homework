﻿using System;


namespace NumberComparer
{
    class Start
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? a : b);
        }
    }
}
