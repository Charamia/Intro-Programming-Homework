using System;


namespace FibonacciNumbers
{
    class Startup
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int xfromNumberN = (numberN - 1) + (numberN + 2);
            int n = 0; 

            if((numberN >= 1) && (numberN <=50))
                {
                for(int i = 0; i <= numberN; i++)
                {
                    Console.WriteLine(n + xfromNumberN); 
                }
               
            }
        }
    }
}
