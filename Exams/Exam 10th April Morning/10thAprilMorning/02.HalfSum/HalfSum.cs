using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _02.HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger firstSum = 0;
            BigInteger secondSum = 0;

            for(int i = 0; i < n ; i++)
            {
                BigInteger num = BigInteger.Parse(Console.ReadLine());
                firstSum += num;
            }
            for(int a = 0; a < n; a++)
            {
                BigInteger num1 = BigInteger.Parse(Console.ReadLine());
                secondSum += num1;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum={0}", firstSum);
            }
            else if (firstSum > secondSum)
            {
                firstSum -= secondSum;
                Console.WriteLine("No, diff={0}", firstSum);
            }
            else
            {
                secondSum += firstSum;
                Console.WriteLine("No, diff={0}", secondSum);
            }
            Console.ReadLine();
        }
    }
}
//73 от 100 в Judge
