using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number for c: ");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if(b > a && b > c)
            {
                if(a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a );
                }
            }
            else
            {
                if(b > a)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
            }
            Console.ReadLine();
        }
    }
}
