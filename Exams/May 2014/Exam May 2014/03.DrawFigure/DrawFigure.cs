using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DrawFigure
{
    class DrawFigure
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            for(int i = 0; i <= n /2; i++)
            {
                string clock = new string('*', n - 2 * i);
                string background = new string('.', i);
                Console.WriteLine("{0}{1}{0}", background, clock, background);
            }
            for (int i = n / 2 - 1; i >= 0; i-- )
            {
                string clock = new string('*', n - 2 * i);
                string background = new string('.', i);
                Console.WriteLine("{0}{1}{0}", background, clock, background);
            }
                Console.ReadLine();
        }
    }
}
