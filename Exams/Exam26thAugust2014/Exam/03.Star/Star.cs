using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dotsOut = n;
            int dotsIn = 0;
            int thirdCount = 0;

            for(int i = 0; i <= (n * 2- (n / 2 - 1)); i++)
            {
                if(i == 0)
                {
                    string dot = new string('.', dotsOut);
                    Console.WriteLine(dot + "*" + dot);
                    dotsOut--;
                    dotsIn++;
                }
                else if(i <  n / 2)
                {
                    string dot = new string('.', dotsOut);
                    string innerDot = new string('.', dotsIn);
                    Console.WriteLine(dot + "*" + innerDot + "*" + dot);
                    dotsOut--;
                    dotsIn+=2;
                }
                else if(i == n /2)
                {
                    string dot = new string('*', dotsOut);
                    string innerDot = new string('.', dotsIn);
                    Console.WriteLine(dot + "*" + innerDot + "*" + dot);
                    dotsOut = 1;
                    dotsIn += n-2;
                }
                else if(i > n / 2 && i < n)
                {
                    string dot = new string('.', dotsOut);
                    string innerDot = new string('.', dotsIn);
                    Console.WriteLine(dot + "*" + innerDot + "*" + dot);
                    dotsOut++;
                    dotsIn -=2;
                }
                else if(i == 1 + n)
                {
                    dotsIn = (n - 2) / 2;
                    string dot = new string('.', dotsOut);
                    string innerDot = new string('.', dotsIn);
                    Console.WriteLine(dot + "*" + innerDot + "*" + innerDot + "*" + dot);
                    dotsOut--;
                    thirdCount++;
                }
                else if (i > n + 1 && i < (n * 2 - (n / 2 - 1)))
                {
                    dotsIn = (n - 2) / 2;
                    string dot = new string('.', dotsOut);
                    string innerDot = new string('.', dotsIn);
                    string thirdDot = new string('.', thirdCount);
                    Console.WriteLine(dot + "*" + innerDot + "*" + thirdDot + "*" + innerDot + "*" + dot);
                    dotsOut--;
                    thirdCount+= 2;
                }
                else if (i == (n * 2 - (n / 2 - 1)))
                {
                    dotsIn = (n - 2) / 2;
                    string innerDot = new string('*', dotsIn);
                    string thirdDot = new string('.', thirdCount);
                    Console.WriteLine("*" + innerDot + "*" + thirdDot + "*" + innerDot + "*");
                    dotsOut--;
                    thirdCount += 2;
                }
            }
            Console.ReadLine();
        }
    }
}
