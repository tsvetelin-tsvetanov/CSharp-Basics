using System;

    class ModifyABit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            ushort num = ushort.Parse(Console.ReadLine());
            Console.Write("Enter a position: ");
            byte pos = byte.Parse(Console.ReadLine());
            Console.Write("Enter bit value (0 or 1): ");
            byte value = byte.Parse(Console.ReadLine());
            string bits = Convert.ToString(num, 2);
            int bit = (int)(num >> pos) & 1;
            if (value == 1)
            {
                int setValueToOne = 1 << pos;
                int foundBitOne = num | setValueToOne;
                string bitsOne = Convert.ToString(foundBitOne, 2).PadLeft(16, '0');
                Console.WriteLine("{0}", bitsOne);
            }
            else
            {
                int setValueToZero = ~(1 << pos) << pos;
                int foundBitZero = num & setValueToZero;
                string bitsZero = Convert.ToString(foundBitZero, 2).PadLeft(16, '0');
                Console.WriteLine(bitsZero);
            }
            Console.ReadLine();
        }
    }

