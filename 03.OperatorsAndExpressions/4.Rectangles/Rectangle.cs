using System;

    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = (width * 2) + (height * 2);
            double area = width * height;
            Console.WriteLine("The perimeter of the rectangle is {0} and it's area is {1}", perimeter, area);
            Console.ReadLine();
        }
    }

