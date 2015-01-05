using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            string frame = new string ('*', n * 2);
            string space = new string(' ', n);
            Console.WriteLine("{0}{1}{0}", frame, space, frame);

            for(int i = 0; i < n - 2; i++)
            {
                string lense = new string('/', n * 2 - 2);
                if (i == n / 2 - 1)
                {
                    string bridge = new string('|', n);
                    Console.WriteLine("*{0}*{1}*{0}*", lense, bridge, lense);
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", lense, space, lense);
                }

            }

            Console.WriteLine("{0}{1}{0}", frame, space, frame);
            Console.ReadLine();
        }
    }
}
