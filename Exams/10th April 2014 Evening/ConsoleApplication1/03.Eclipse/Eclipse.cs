using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            //frame
            string frame = new string('*', n * 2 - 2);
            string spaceFrame = new string(' ', n+1);
            Console.WriteLine(" {0}{1}{0} ", frame, spaceFrame, frame);
            for (int i = 0; i < n - 2; i++ )
            {
                string lense = new string('/', n * 2 - 2);
                if (i == (n / 2) - 1)
                {
                    string bridge = new string('-', n - 1);
                    Console.WriteLine("*{0}*{1}*{0}*", lense, bridge, lense);
                }
                else
                {
                    string spaceLense = new string(' ', n - 1);
                    Console.WriteLine("*{0}*{1}*{0}*", lense, spaceLense, lense);
                }
            }
            Console.WriteLine(" {0}{1}{0} ", frame, spaceFrame, frame);
                Console.ReadLine();
        }
    }
}
