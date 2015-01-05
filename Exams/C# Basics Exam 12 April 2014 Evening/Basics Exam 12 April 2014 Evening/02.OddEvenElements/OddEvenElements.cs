using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            decimal oddSum = 0;
            decimal evenSum = 0;
            decimal oddMin = decimal.Parse(nums[0]);
            decimal oddMax = decimal.Parse(nums[0]);
            decimal evenMin = decimal.Parse(nums[1]);
            decimal evenMax = decimal.Parse(nums[1]);
            bool odd = true;

            for (int i = 0; i < nums.Length; i++)
            {
                decimal temp = decimal.Parse(nums[i]);
                if (odd)
                {
                    oddSum += temp;
                    if (temp > oddMax)
                        oddMax = temp;
                    if (temp < oddMin)
                        oddMin = temp;
                }
                else
                {
                    evenSum += temp;
                    if (temp > evenMax)
                        evenMax = temp;
                    if(temp < evenMin)
                        evenMin = temp;
                }
                odd = !odd;
            }

            if (nums.Length == 0)
            {
                Console.WriteLine(
                    "OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else if (nums.Length == 1)
            {
                Console.WriteLine(
                    "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                    (double)oddSum, (double)oddMin, (double)oddMax);
            }
            else
            {
                Console.WriteLine(
                    "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                    (double)oddSum, (double)oddMin, (double)oddMax,
                    (double)evenSum, (double)evenMin, (double)evenMax);
            }
            Console.ReadLine();
            //75 oт 100
            //трябва да измисля как да чета минимума и максимума
            //мисля че имам идея, по-късно ще се върна на нея
            //при инициализацията да задам oddMin,Max, evenMin,Max = 0
            //и във фор-а да проверявам дължината на символите в масива
            //и съответно там да присвоя мин и макс
        }
    }
}
