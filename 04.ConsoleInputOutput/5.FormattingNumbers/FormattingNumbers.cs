using System;

    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer number from 0 to 500: ");
            int a = int.Parse(Console.ReadLine());
            if (a>=0 && a<=500)
            {
                Console.Write("Enter a float number: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Enter a float number: ");
                float c = float.Parse(Console.ReadLine());
                string hex = a.ToString("x");
                string bin = Convert.ToString(a, 2);
                Console.Write("|{0,-10}", hex);
                Console.Write("|{0,0}", bin);
                Console.Write("|{0,10}", Math.Round(b, 2));
                Console.Write("|{0,-10}|", Math.Round(c, 3));
            }
            else
            {
                Console.WriteLine("The number is not in the interval 0 - 500 ");
            }
            Console.ReadLine();
        }
    }

