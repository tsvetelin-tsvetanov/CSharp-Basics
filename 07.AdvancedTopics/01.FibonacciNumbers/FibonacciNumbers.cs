using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = CalcFibonacci(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int CalcFibonacci(int n)
        {
            int fibonacci = 1;
            int n1 = 0;
            int n2 = 1;
            for (int i = 0; i < n; i++)
            {
                fibonacci = n1 + n2;
                n1 = n2;
                n2 = fibonacci;
            }
            return fibonacci ;
        }
    }
}
