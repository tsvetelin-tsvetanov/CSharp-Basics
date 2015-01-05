using System;

    class Trapezoids
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double h = double.Parse(Console.ReadLine());
            //calculations
            double area = ((a + b) / 2) * h;
            Console.WriteLine("The area of the trapezoid is: {0}", area);
            Console.ReadLine();
        }
    }

