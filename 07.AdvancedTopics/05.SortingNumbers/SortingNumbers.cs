using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nums[i] = number;
            }
            Array.Sort(nums);
            Console.WriteLine( );
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
