using System;

    class NumberCompare
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double b = double.Parse(Console.ReadLine());
            double greater = a > b ? a : b;
            Console.WriteLine(greater);
            Console.ReadLine();
        }
    }

