using System;


namespace CompanyInfo
{
    class Stratup
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            int faxNumber = int.Parse(Console.ReadLine());
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            int managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            if (int.TryParse(Console.ReadLine(), out faxNumber))
            {
                Console.WriteLine("Fax: " + faxNumber);
            }
            else
            {
                Console.WriteLine("Fax: (no fax)" );
            }
            Console.WriteLine("Web site: " + webSite);
            Console.Write("Manager: " + managerFirstName + " " + managerLastName + ("age: " + managerAge + ", " + "tel: " + managerPhone));
        }
    }
}
