using System;
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number: ");
            int a = int.Parse(Console.ReadLine());
            if(a%2 != 0)
            {
                Console.WriteLine("Odd?: True");
            }
            else
            {
                Console.WriteLine("Odd?: False");
            }
            Console.Read();
        }
    }
