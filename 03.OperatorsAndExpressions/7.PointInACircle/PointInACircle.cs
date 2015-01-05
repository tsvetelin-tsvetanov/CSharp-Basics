using System;

    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            bool check = (x * x) + (y * y) <= (2 * 2);
            Console.WriteLine(check);
            Console.Read();
        }
    }

