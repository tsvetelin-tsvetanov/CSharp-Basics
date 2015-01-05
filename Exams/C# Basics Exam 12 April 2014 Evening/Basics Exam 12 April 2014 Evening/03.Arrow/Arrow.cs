using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outDots = (n - 1) / 2;
            int inDots = (n - 2);
            int outCount = 1;
            int inCount = 2 * n - 5;

            for(int i = 0; i < (n * 2) - 1; i++)
            {
                if (i == 0)
                {
                    string hashtag = new string('#', n);
                    string dots = new string('.', outDots);
                    Console.WriteLine(dots + hashtag + dots);
                }
                else if (i <= n - 2)
                {
                    string outerDots = new string('.', outDots);
                    string innerDots = new string('.', inDots);
                    Console.WriteLine(outerDots + '#' + innerDots + '#' + outerDots);
                }
                else if (i == n)
                {
                    string hashtag = new string('#', outDots);
                    string innerDots = new string('.', inDots);
                    Console.WriteLine(hashtag + '#' + innerDots + '#' + hashtag);
                }
                else if(i > n)
                {
                    string outerDots = new string('.', outCount);
                    string innerDots = new string('.', inCount);
                    Console.WriteLine(outerDots + '#' + innerDots + '#' + outerDots);
                    outCount ++;
                    inCount -= 2;
                }

            }
            string dotsLast = new string('.', n - 1);
            Console.WriteLine(dotsLast + '#' + dotsLast);
            Console.ReadLine();
            //100 от 100
            //дотук общо 275 от 500

        }
    }
}
