using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            long dec = 0;
            long count = 1;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int num;
                switch (hex[i])
                {
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                    default: num = (int)hex[i] - 48; break;
                }
                dec += num * count;
                count *= 16;
            }
            Console.WriteLine(dec);
            Console.ReadLine();
        }
    }
}
