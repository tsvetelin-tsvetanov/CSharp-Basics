using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SequenceOfKNumbers
{
    class SequenceOfKNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            int count = 1;
            string[] nums = input.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            string lastChar = nums[0];
            int elements = 0;
            for (int i = 1; i < nums.Length; i++)
            {

                if (lastChar == nums[i])
                {
                    count++;
                }
                else
                {
                    if (count >= k)
                        elements = count % k;
                    for (int j = 0; j < elements; j++)
                    {
                        Console.Write(lastChar + " ");
                    }
                    count = 1;

                }
                lastChar = nums[i];

            }
            elements = count;
            if (count >= k)
            {
                elements = count % k;
            }

            for (int j = 0; j < elements; j++)
            {
                Console.Write(" " + lastChar);
                
            }
            Console.ReadLine();
        }
    }
}
