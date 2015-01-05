using System;

    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int count = 0;
            if (number == 1)
            {
                isPrime = false;
            }
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if(count>2)
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime);
            Console.Read();
        }
    }

