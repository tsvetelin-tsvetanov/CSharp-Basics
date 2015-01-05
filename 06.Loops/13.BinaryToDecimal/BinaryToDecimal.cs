using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            long dec = 0;
            int count = 1;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                int num = bin[i] - 48;
                dec += num * count;
                count *= 2;
            }
            Console.WriteLine(dec);
            Console.ReadLine();
        }
    }
}
