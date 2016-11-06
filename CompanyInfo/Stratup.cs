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
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge;
            int.TryParse(Console.ReadLine(), out managerAge);
            string managerPhone = Console.ReadLine();
            
            
            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);

            
            if(!string.IsNullOrEmpty(faxNumber))
            {
                Console.WriteLine("Fax: " + faxNumber);
            }
            else
            {
                Console.WriteLine("Fax: (no fax)" );
            }
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", " + "tel. " + managerPhone +")");
        }
    }
}
