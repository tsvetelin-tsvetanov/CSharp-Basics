using System;

    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object full = hello + " " + world;
            Console.WriteLine("{0}", full);
            Console.ReadLine();
        }
    }

