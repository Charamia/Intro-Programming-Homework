using System;


namespace FourDigits
{
    class Stratup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int a = int.Parse(input[0].ToString());
            int b = int.Parse(input[1].ToString());
            int c = int.Parse(input[2].ToString());
            int d = int.Parse(input[3].ToString());

            int sum = a + b + c + d;
            Console.WriteLine(sum);
            Console.WriteLine(d + "" + c + "" + b + "" +a);
            Console.WriteLine(d + "" + a + "" + b + "" + c);
            Console.WriteLine(a + "" + c + "" + b + "" + d);

            
        }
    }
}
 

