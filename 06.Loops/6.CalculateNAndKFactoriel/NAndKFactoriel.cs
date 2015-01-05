using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CalculateNAndKFactoriel
{
    class NAndKFactoriel
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number for N < 100: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for K < N < 100: ");
            int k = int.Parse(Console.ReadLine());
            if(k > n)
                Console.WriteLine("Invalid value for n and k");
            else
            {
                int sumN = 1;
                int sumK = 1;
                int result = 0;
                for (int i = 1; i <= n; i++ )
                {
                    sumN *= i;
                    if (i > k)
                    {
                       goto done;
                    }
                    else
                    {
                        sumK *= i;
                    }
                    done:;
                }
                result = sumN / sumK;
                Console.WriteLine("The result is: {0}", result);
            }
            Console.ReadLine();
        }
    }
}
