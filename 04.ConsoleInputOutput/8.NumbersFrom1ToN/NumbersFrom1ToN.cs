using System;

    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }

