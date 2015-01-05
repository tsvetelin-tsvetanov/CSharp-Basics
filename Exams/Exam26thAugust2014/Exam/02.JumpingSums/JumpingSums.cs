using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JumpingSums
{
    class JumpingSums
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            int jumps = int.Parse(Console.ReadLine());
            int[] arrayNums =nums.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int sum = 0;
            int index = 0;
            int tempSum = 0;

            for (int a = 0; a < arrayNums.Length; a++)
            {
                
                tempSum = 0;
                index = a;
                for(int i = 0; i <= jumps; i++)
                {
                    while (index > arrayNums.Length - 1)
                        index -= arrayNums.Length;
                    index += arrayNums[index];
                    tempSum += index;
                }
                if (tempSum > sum)
                    sum = tempSum;
            }

            Console.WriteLine("max sum = {0}", sum);
            Console.ReadLine();
        }
    }
}
