using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimesInRange
{
    class PrimesInRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string result = PrimeCheck(start, end);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static string PrimeCheck(int start, int end)
        {
            string nums = "";
            int count = 0;
            if (start == 0)
                start = 2;
            for (int i = start; i <= end - start; i++)
            {
                if(start % i == 0)
                {
                    count++;
                }
                if (count <= 2)
                    nums = i + ", ";
            }
            return nums;
            //не е завършена
        }
    }
}
