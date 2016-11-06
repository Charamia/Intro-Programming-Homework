using System;


namespace SumofNnumbers
{
    class StartUp
    {
        static void Main()
        {
            double numberN = double.Parse(Console.ReadLine());
            double sumofNumbers = 0;

            for (double i =1; i<= numberN; i++)
            {
                double numberX = double.Parse(Console.ReadLine());
                sumofNumbers += numberX;
            }

            Console.WriteLine(sumofNumbers);
        }
    }
    
}
