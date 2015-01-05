using System;

    class NullValueArithmetic
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("{0}", a);
            Console.WriteLine("{0}", b);
            int? someNumber = a + null;
            double? someDouble = b / 0;
            Console.WriteLine("{0}", someNumber);
            Console.WriteLine("{0}", someDouble);
            Console.ReadLine();
        }
    }

