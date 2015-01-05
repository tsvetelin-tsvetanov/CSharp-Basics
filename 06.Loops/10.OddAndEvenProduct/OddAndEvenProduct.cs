using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some integer numbers: ");
            string input = Console.ReadLine();
            string [] nums = input.Split(' ');
            int oddSum = 1;
            int evenSum = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                int n = int.Parse(nums[i]);
                if (i % 2 == 0)
                {
                    oddSum *= n;
                }
                else
                    evenSum *= n;
            }
            if(oddSum == evenSum)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("Product of the odd numbers: {0}", oddSum);
                Console.WriteLine("Product of the even numbers: {0}", evenSum);
            }
            Console.ReadLine();
        }
    }
}
