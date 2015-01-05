using System;

    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1= {0}\nx2= {1}", x1, x2);
            Console.ReadLine();
        }
    }

