using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            uint n = uint.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            decimal sum = 0m;
            int counter = 0;
            while(counter < n)
            {
                Console.Write("Enter another number: ");
                int num = int.Parse(Console.ReadLine());
                min = num;
                if (min > num)
                    min = num;
                if(max < num)
                {
                    max = num;
                }
                sum += num;
                counter++;
            }
            decimal avg = sum / n;
            Console.WriteLine("min: {0}\nmax: {1}\nsum: {2}", min, max, sum);
            Console.WriteLine("avg: {0:f2}", avg);
            Console.ReadLine();
            //да му оправя смятането

        }
    }
}
