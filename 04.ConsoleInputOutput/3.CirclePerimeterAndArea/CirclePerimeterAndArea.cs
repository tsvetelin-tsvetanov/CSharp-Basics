using System;

    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = (2 * radius) * Math.PI;
            double area = Math.PI * (radius * radius);
            Console.WriteLine("The perimeter of the circle is {0} and the area is {1}", Math.Round(perimeter, 2), Math.Round(area, 2));
            Console.ReadLine();
        }
    }

