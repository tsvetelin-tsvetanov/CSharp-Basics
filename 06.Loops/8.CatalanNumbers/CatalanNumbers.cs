using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _8.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range 1 < n < 100: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            if(n == 0)
            {
                Console.WriteLine("The result is: 1");
                
            }
            else if (n < 1 || n > 100)
                Console.WriteLine("Invalid value for n");
            else
            {
                BigInteger a = 1;
                BigInteger b = 1;
                BigInteger result = 1;

                for(int i = 2; i<=n; i++ )
                {
                    a *= (i+n);
                    if (a % i == 0)
                        a /= i;
                    else 
                        b *= i;
                    result = a / b;
                }
                Console.WriteLine("The result is: {0}", result);
            }
            Console.ReadLine();
        }
    }
}
