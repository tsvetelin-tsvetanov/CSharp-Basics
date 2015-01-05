using System;

    class ThirdDigit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check: ");
            int number = int.Parse(Console.ReadLine());
            int firstCheck = number / 100;
            bool secondCheck = (Math.Abs(firstCheck) % 10 == 7);
            Console.WriteLine("The third digit of {0} from right to left is 7: {1}", number, secondCheck);
            Console.Read();
        }
    }

