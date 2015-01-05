using System;

    class PointInsideACircle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            bool InCircle = ((((x * x) - (2 * x) + 1) + ((y * y) - (2 * y) + 1)) <= (1.5 * 1.5));
            bool OutRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
            if(InCircle && OutRectangle)
            {
                Console.WriteLine("No");
            }
            else if(InCircle && !OutRectangle)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
        }
    }

