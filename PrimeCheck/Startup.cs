using System;


namespace PrimeCheck
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string isPrime = "true";


            if(n <= 1)
            {
                isPrime = "false";
            }
            if((n % 2 == 0 && n != 2) || (n % 3 == 0 && n != 3) || (n % 5 == 0 && n != 5) || ( n % 7 == 0 && n != 7))
            {
                isPrime = "false";
            }


            Console.WriteLine(isPrime);
            
        }
    }
}
