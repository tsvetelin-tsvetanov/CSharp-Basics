using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NumbersNotDivisableByThreeAndSeven
{
    class NumbersNotDivisableByThreeAndSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers not divisable by 3 and 7");
            Console.Write("Enter a positive integer number: ");
            uint n = uint.Parse(Console.ReadLine());
            int i = 1;
            for (i = 1; i <= n; i++ )
            {
                if(i % 7 == 0 || i % 3 == 0)
                {
                    continue;

                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
