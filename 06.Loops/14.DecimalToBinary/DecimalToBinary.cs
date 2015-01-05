using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            string bin = "";
            while (dec != 0)
            {
                int count = (int) dec % 2;
                dec /= 2;
                bin = count + bin;
            }
            Console.WriteLine(bin);
            Console.ReadLine();
        
        }
    }
}
