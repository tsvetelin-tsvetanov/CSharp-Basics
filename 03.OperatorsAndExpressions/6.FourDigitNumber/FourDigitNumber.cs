using System;

    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your four digit number: ");
            int number = int.Parse(Console.ReadLine());
            //fourth digit
            int fourthNumber = number % 10;
            //third digit
            int thirdNumberCheck = number / 10;
            int thirdNumber = thirdNumberCheck % 10;
            //second digit
            int secondNumberCheck = number / 100;
            int secondNumber = secondNumberCheck % 10;
            //first digit
            int firstNumberCheck = number / 1000;
            int firstNumber = firstNumberCheck % 10;
            //sum of the digits
            int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;
            //Print
            Console.WriteLine("The sum of the digits in number {0} is: {1}", number, sum);
            Console.WriteLine("Reversed: {0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNumber);
            Console.WriteLine("Last digit first: {0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("Exchanged 2nd and 3rd: {0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
            Console.Read();
        }
    }

