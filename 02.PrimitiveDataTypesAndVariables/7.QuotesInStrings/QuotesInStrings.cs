using System;

    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string Quoted = @"The ""use"" of quotations causes difficulties.";
            string unQuoted = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("With quote: {0}", Quoted);
            Console.WriteLine("Without quote: {0}", unQuoted);
            Console.ReadLine();
        }
    }
