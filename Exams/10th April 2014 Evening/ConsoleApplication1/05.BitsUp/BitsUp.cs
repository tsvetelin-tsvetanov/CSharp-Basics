using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitsUp
{
    class BitsUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                {
                    if ((count % step == 1) || (step == 1 && count > 0))
                    {
                        num = num | (1 << bit);
                    }
                    count++;
                }
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
