using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double b = double.Parse(Console.ReadLine());
            double c = 0;
            if(a>b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            Console.ReadLine();
        }
    }
}
