using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeChecker
{
    class PrimeCheck
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result = Checker(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static bool Checker(int n)
        {
            bool prime = true;
            int count = 0;
            if (n == 0)
                prime = false;
            else if (n == 1)
                prime = false;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                prime = false;
            }
            return prime;
        }
    }
}
