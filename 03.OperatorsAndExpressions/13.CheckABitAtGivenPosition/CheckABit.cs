using System;

    class CheckABit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            ushort num = ushort.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int pos = int.Parse(Console.ReadLine());
            string bits = Convert.ToString(num, 2);
            int bit = (int)(num >> pos) & 1;
            bool check = (bit == 1);
            Console.WriteLine(check);
            Console.ReadLine();
        }
    }

