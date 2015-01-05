using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BiggestOfFive
{
    class BiggestOfFive
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number for c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter number for d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter number for e: ");
            double e = double.Parse(Console.ReadLine());
            if(a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a);
            }
            else if(b > a && b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }
            else if(c > a && c > b && c > d && c > e)
            {
                Console.WriteLine(c);
            }
            else if(d > a && d > b && d > c && d > e)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
