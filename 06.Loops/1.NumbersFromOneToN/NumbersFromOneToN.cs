using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            uint n = uint.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
