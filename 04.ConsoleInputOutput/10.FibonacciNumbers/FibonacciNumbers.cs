using System;

    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int aTemp = 0;
            int bTemp = 1;
            for(int i = 0; i<n; i++)
            {
                Console.Write(aTemp + " ");
                int temp = aTemp;
                aTemp = bTemp;
                bTemp = temp + bTemp;
            }
            Console.ReadLine();
        }
    }

