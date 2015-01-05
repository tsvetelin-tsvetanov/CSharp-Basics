using System;

    class AgeAfter10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be:{0}", Age+10);
            Console.Read();
        }
    }

