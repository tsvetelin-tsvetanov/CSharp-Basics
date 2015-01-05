using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TrailingZeroesInNFactoriel
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zero = 0;
            int a;
            for (int i = 5; i <= n; i += 5)
            {
                a = i;
                while (a % 5 == 0)
                {
                    a /= 5;
                    zero++;
                }
            }
            Console.WriteLine(zero);
            Console.ReadLine();
        }
    }
}
