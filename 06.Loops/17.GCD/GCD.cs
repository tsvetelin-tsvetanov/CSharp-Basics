using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = a % b;
            while (result != 0)
            {
                a = b;
                b = result;
                result = a % b;
            }
            Console.WriteLine(Math.Abs(b));
            Console.ReadLine();
        }
    }
}
