using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.SimpleLoop
{
    class SimpleLoop
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger d = 0;
            int count = 0;
            for(int i = 0; i < n - 3; i++)
            {
                if (count != 0)
                {
                    a = b;
                    b = c;
                    c = d;
                }
                d = a + b + c;
                count++;
            }
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}

//90 от 100 в judge
