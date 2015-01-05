using System;

    class EmployeeData
    {
        static void Main(string[] args)
        {
            String FirstName = "Tsvetelin";
            String LastName = "Tsvetanov";
            byte age = 19;
            char gender = 'm';
            long personalID = 8306112507;
            uint employeeNumber = 27569999;
            Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonalID: {4}\nEmployee Number: {5}", FirstName, LastName, age, gender, personalID, employeeNumber);
            Console.ReadLine();
        }
    }

