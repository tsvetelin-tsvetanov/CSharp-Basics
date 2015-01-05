using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitsKiller
{
    class BitsKiller
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            string totalBits = "0";
            string print = "0";

            for(int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string bits = Convert.ToString(n, 2).PadLeft(32, '0');
                totalBits += bits;
             }

            
            Console.WriteLine(totalBits);
            Console.ReadLine();
        }
    }
}
