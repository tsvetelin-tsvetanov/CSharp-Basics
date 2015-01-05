using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            string hex = "";
            if (dec == 0)
            {
                hex = "0";
            }
            else
            {
                while (dec > 0)
                {
                    long count = dec % 16;
                    dec /= 16;
                    switch (count)
                    {
                        case 10: hex = "A" + hex; break;
                        case 11: hex = "B" + hex; break;
                        case 12: hex = "C" + hex; break;
                        case 13: hex = "D" + hex; break;
                        case 14: hex = "E" + hex; break;
                        case 15: hex = "F" + hex; break;
                        default: hex = count + hex; break;
                    }
                }
            }
            Console.WriteLine(hex);
            Console.ReadLine();
        }
    }
}
