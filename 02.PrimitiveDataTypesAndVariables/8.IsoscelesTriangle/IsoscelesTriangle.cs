using System;

    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            string c = "\u00a9";
            string space = " ";
            Console.WriteLine("{0} {1} {2} {3} ", space, space, space, c);
            Console.WriteLine("{0} {1} {2} {3} {4}", space, space, c, space, c);
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", space, c, space, space, space, c);
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", c, space, c, space, c, space, c);
            Console.ReadLine();
        }
    }

