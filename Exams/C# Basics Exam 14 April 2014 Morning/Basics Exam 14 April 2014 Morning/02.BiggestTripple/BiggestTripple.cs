using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BiggestTripple
{
    class BiggestTripple
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            object print = 0;
            int count = 0;

            string[] nums = input.Split(' ');
            while(count < nums.Length)
            {
                int num1 = int.Parse(nums[count]);
                count++;
                int num2 = 0;
                if(count < nums.Length)
                {
                    num2 = int.Parse(nums[count]);
                    count++;
                }
                int num3 = 0;
                if(count < nums.Length)
                {
                    num3 = int.Parse(nums[count]);
                    count++;
                }
                int tempSum = num1 + num2 + num3;
                if (tempSum > sum)
                {
                    sum = tempSum;
                    string firstNum = Convert.ToString(num1);
                    if (num2 == 0 && num3 == 0)
                    {
                        print = firstNum;
                    }
                    else if (num3 == 0)
                    {
                        string secondNum = Convert.ToString(num2);
                        print = firstNum + ' ' + secondNum;
                    }
                    else
                    {
                        string secondNum = Convert.ToString(num2);
                        string thirdNum = Convert.ToString(num3);
                        print = firstNum + ' ' + secondNum + ' ' + thirdNum + ' ';
                    }
                }
            }
            Console.WriteLine(print);
            Console.ReadLine();
            //81 oт 100
        }
    }
}
