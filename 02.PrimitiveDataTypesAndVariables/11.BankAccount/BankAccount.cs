using System;
class BankAccount
    {
        static void Main(string[] args)
        {
            String FirstName = "Tsvetelin";
            String MiddleName = "Vladkov";
            String LastName = "Tsvetanov";
            decimal balance = 2400;
            String BankName = "First Investment Bank";
            String IBAN = "BG74STSA93001946DEU16";
            ulong Card1 = 378282246310005;
            ulong Card2 = 5610591081018250;
            ulong Card3 = 5105105105105100;
            Console.WriteLine("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}", FirstName, MiddleName, LastName);
            Console.WriteLine("Available amount of money: {0} lv.\nBank Name: {1}\nIBAN: {2}", balance, BankName, IBAN);
            Console.WriteLine("Credit Card 1: {0}\nCredit Card 2: {1}\nCredit Card 3: {2}", Card1, Card2, Card3);
            Console.ReadLine();
        }
    }

