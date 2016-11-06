using System;


namespace NumbersFom1toN
{
    class Startup
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
           
            for(int i = 1; i <= N; i++)
            {
               
                Console.WriteLine(i);
            }
        }
    }
}
