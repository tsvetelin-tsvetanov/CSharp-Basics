using System;
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your number: ");
            int a = int.Parse(Console.ReadLine());
            bool checkIfDivides = ((a % 5 == 0) && (a % 7 == 0));
            Console.WriteLine("The entered number can be divided by 5 and 7: {0}", checkIfDivides);
            Console.ReadLine();
        }
    }

