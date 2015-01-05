using System;

    class NumbersInInterval
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter another positive integer number: ");
            int b = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i=a; i<=b; i++)
            {
                if(i % 5 == 0)
                {
                    p++;
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine(p + " numbers" );
            Console.ReadLine();
        }
    }

