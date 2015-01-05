using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TheBiggestOfThree
{
    class BiggestOfThree
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number for c: ");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c )
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
