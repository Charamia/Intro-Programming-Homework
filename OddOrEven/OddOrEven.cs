using System;


namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int min = -30;
            int max = 30;
            int chislo = int.Parse(Console.ReadLine());
            if (chislo % 2 ==0)
            {
                Console.WriteLine("even " + chislo);
            }
            else
            {
                Console.WriteLine("odd " + chislo);
            }


        }
    }
}
