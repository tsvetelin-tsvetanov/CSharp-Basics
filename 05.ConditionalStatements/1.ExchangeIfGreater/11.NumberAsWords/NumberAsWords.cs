using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            string[] first = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                             "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] second = {null, "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"  };
            Console.Write("Enter your number from 0 to 999: ");
            int num = int.Parse(Console.ReadLine());
            //third digit
            int thirdDigit = num % 10;
            //second digit
            int secondDigitCheck = num / 10;
            int secondDigit = secondDigitCheck % 10;
            //first digit
            int firstDigitCheck = num / 100;
            int firstDigit = firstDigitCheck % 10;
            //check numbers from 0 to 9
            string print = null;
            if(num < 20)
            {
                print = first[num];
            }
            else if(num >= 20 && num <100)
            {
                print = second[secondDigit] +" " +  first[thirdDigit];
            }
            else
            {
                print = first[firstDigit] + " hundred and " + second[secondDigit] + " " + first[thirdDigit];
            }
            Console.WriteLine(print);
            Console.ReadLine();
        }
    }
}
