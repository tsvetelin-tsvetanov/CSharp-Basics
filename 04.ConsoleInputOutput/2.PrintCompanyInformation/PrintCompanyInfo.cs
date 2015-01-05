using System;

    class PrintCompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string coName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string coAddress = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Enter web site: ");
            string web = Console.ReadLine();
            Console.Write("Enter manager's first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter manager's last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter manager's age: ");
            sbyte age = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter manager's phone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",coName, coAddress, phone, fax, web, managerFirstName, managerLastName, age, managerPhone);
            Console.ReadLine();
        }
    }

