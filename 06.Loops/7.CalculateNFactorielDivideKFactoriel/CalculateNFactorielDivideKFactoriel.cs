using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _7.CalculateNFactorielDivideKFactoriel
{
    class CalculateNFactorielDivideKFactoriel
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number for N < 100: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for K < N < 100: ");
            int k = int.Parse(Console.ReadLine());
            if (k > n)
                Console.WriteLine("Invalid value for n and k");
            else
            {
                BigInteger sumN = 1;
                BigInteger sumK = 1;
                BigInteger result = 0;
                BigInteger nk = 1;
                for (int i = 1; i <= n; i++)
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
                    
                done: ;
                }
                for (int a = 1; a <= (n - k); a++)
                {
                    nk *= a;
                }
                result = sumN / (sumK * nk);  
                Console.WriteLine("The result is: {0}", result);
            }
            Console.ReadLine();
        }
    }
}
