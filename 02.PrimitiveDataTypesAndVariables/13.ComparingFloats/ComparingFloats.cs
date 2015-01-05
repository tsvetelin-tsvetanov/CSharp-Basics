using System;

    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            decimal b = decimal.Parse(Console.ReadLine());
            bool result = (Math.Abs(a - b) < 0.000001m);
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
