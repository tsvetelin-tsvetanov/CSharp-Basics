using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {
            string scanner = Console.ReadLine();
            string[] numberStrs = scanner.Split(' ');
            int[] numbers = new int[numberStrs.Length];

            int sum = 0;
            int tempSum = 0;
            int diff = 0;
            int maxDiff = 0;
            int count = 0;
            bool pair = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                int num1 = int.Parse(numberStrs[i]);
                i++;
                int num2 = int.Parse(numberStrs[i]);
                sum = num1 + num2;

                if(count == 0)
                {
                    count++;
                    tempSum = sum;
                }
                else if (tempSum > sum || tempSum < sum)
                {
                    if (tempSum > sum)
                        diff = tempSum - sum;
                    else
                    {
                        diff = sum - tempSum;
                        tempSum = sum;
                    }
                    pair = false;
                }
                if (diff > maxDiff)
                    maxDiff = diff;
            }

            if(pair == true)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
            Console.ReadLine();
            //75 oт 100
            //дотук 175 от 500
        }
    }
}
