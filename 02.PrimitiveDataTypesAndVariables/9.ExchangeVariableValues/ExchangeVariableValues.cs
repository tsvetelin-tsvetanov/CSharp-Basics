using System;

    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = b;
            int d = a; 
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("a new = {0}", c);
            Console.WriteLine("b new = {0}", d);
            Console.ReadLine();

        }
    }

