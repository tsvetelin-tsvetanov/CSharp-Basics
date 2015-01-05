using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate_1___1
{
    class Calculate 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for x: ");
            int x = int.Parse(Console.ReadLine());
            if(n < 1)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                double factorielN = 1;
                double numX = 1;
                double sum = 1;
                for(int i = 1; i <= n; i++)
                {
                    factorielN *=i;
                    numX *= x;
                    sum += (factorielN/numX);
                }
                Console.WriteLine("The sum is = {0:F5}", sum);
            }
            Console.ReadLine();
        }
    }
}
