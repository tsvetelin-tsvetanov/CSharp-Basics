using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WineGlass
{
    class WineGlass
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int count = 1;
            int asteriskCount = height - 2;
            
            for(int a = 1; a <= height; a++ )
            {
                if(a == 1)
                {
                    string asterisk = new string ('*', asteriskCount);
                    Console.WriteLine("\\{0}/", asterisk);
                    asteriskCount -= 2;
                }
                else if (a < height / 2)
                {

                    string dots = new string('.', count);
                    string asterisk = new string('*', asteriskCount);
                    Console.WriteLine(dots + '\\' + asterisk + '/' + dots);
                    asteriskCount -= 2;
                    count += 1;
                }
                else if (a == height / 2)
                {
                    string dots = new string('.', count);
                    Console.WriteLine(dots + '\\' + '/' + dots);
                }
                else if (height < 12 && a < height || height >= 12 && a < height - 1)
                {
                    string dots = new string('.', height / 2 - 1);
                    Console.WriteLine(dots + '|' + '|' + dots);
                }
                else
                {
                    string endLine = new string('-', height);
                    Console.WriteLine(endLine);
                }

            }

                Console.ReadLine();
            //100 oт 100
        }
    }
}
