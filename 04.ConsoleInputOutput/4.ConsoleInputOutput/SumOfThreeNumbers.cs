using System;

    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter your third number: ");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine("The sum of the numbers {0}, {1} and {2} is: {3}", a, b, c, sum);
            Console.ReadLine();
        }
    }

