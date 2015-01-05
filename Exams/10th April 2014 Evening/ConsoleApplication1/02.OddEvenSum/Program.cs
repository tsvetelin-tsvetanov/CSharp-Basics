using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //вход за броя на числата
            int sumOdd = 0;
            int sumEven = 0;
            int diff = 0;
            for(int i = 1; i <= n * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOdd += num;
                }
                else
                {
                    sumEven += num;
                }
            }

            if(sumEven == sumOdd)
            {
                Console.WriteLine("Yes, sum={0}", sumOdd);
            }
            else if(sumEven > sumOdd)
            {
                diff = sumEven - sumOdd;
                Console.WriteLine("No, diff={0}", diff);
            }
            else
            {
                diff = sumOdd - sumEven;
                Console.WriteLine("No, diff={0}", diff);
            }
            Console.ReadLine();
        }
    }
}
