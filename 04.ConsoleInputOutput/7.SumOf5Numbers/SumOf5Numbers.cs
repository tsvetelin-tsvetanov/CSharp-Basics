using System;

    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            float c = float.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            float d = float.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            float e = float.Parse(Console.ReadLine());
            float sum = (a) + (b) + (c) + (d) + (e);
            Console.WriteLine("{0} {1} {2} {3} {4} sum= {5}", a, b, c, d, e, sum);
            Console.ReadLine();
        }
    }

