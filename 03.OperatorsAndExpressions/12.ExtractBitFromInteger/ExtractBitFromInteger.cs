using System;

    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check: ");
            ushort number = ushort.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int pos = int.Parse(Console.ReadLine());
            string bits = Convert.ToString(number, 2);
            int bit = (int)(number >> pos) & 1;
            Console.WriteLine("The bit in position {0} in number {1} is {2}", pos, bits, bit);
            Console.ReadLine();
        }
    }

