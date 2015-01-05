using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HouseWithAWindow
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dotCount = 0;
            int innerCount = 0;

            for(int i = 0; i < 2 * n + 2; i++)
            {

                if(i == 0)
                {
                    dotCount = n - 1;
                    innerCount = -1;
                    string dots = new string('.', dotCount);
                    Console.WriteLine(dots + "*" + dots);
                    dotCount--;
                    innerCount += 2;
                }
                else if(i < n && i > 0)
                {
                    string dots = new string('.', dotCount);
                    string innerDot = new string('.', innerCount);
                    Console.WriteLine(dots + "*" + innerDot + "*" + dots);
                    dotCount--;
                    innerCount += 2;
                }
                else if(i == n)
                {
                    string asterisk = new string('*', n * 2 - 1);
                    Console.WriteLine(asterisk);
                }
                else if(i > n && i < n * 2 + 1)
                {
                    if ()
                    {
                        innerCount = n / 2; 
                        string asterisk = new string('*', n + 1 - 4);
                        string innerDot = new string('.', innerCount);
                        Console.WriteLine("*" + innerDot + asterisk + innerDot + "*");

                    }
                    else
                    {
                        innerCount = n * 2 - 3;
                        string innerDot = new string('.', innerCount);
                        Console.WriteLine("*" + innerDot + "*");
                    }
                }
                else
                {
                    string asterisk = new string('*', n * 2 - 1);
                    Console.WriteLine(asterisk);
                }
            }
            Console.ReadLine();
        }
    }
}
