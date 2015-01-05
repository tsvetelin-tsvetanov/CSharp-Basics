using System;

    class ExtractBitNumber3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check: ");
            ushort number = ushort.Parse(Console.ReadLine());
            string bits = Convert.ToString(number, 2);
            ushort position = 3;
            int bit = (int)(number >> position) & 1;
            Console.WriteLine("The third bit in {0} is: {1}", number, bit);
            Console.WriteLine("{0}", bits);
            Console.ReadLine();
        }
    }

