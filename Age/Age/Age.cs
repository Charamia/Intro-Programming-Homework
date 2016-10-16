namespace Age
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Age
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            DateTime DOB = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int age = now.Year - DOB.Year;
            if(now.Month <= DOB.Month && now.Day < DOB.Day)
            {
                age--;
            }
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
