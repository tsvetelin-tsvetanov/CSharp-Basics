using System;

    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a int number: ");
            int a = int.Parse(Console.ReadLine());
            double sum = 0;
            for(int i = 1; i<=a; i++)
            {
                Console.Write("Enter a number:");
                double n = double.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum);
            Console.ReadLine();
        }
    }

