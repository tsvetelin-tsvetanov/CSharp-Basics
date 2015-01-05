using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.InsideTheBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            int x5 = int.Parse(Console.ReadLine());
            int y5 = int.Parse(Console.ReadLine());

            //проверка за x1
            if(x1 <= h * 3 && x1 >= 0 && y1 >= 0)
            {
                if(x1 >= h && x1 <= h * 2)
                {
                    if(y1 <= h * 4)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
                else if(x1 <= h || x1 >= h * 2 && x1 <= h * 3)
                {
                    if(y1 <= h)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
            }
            else
                Console.WriteLine("outside");

            //проверка за x2
            if (x2 <= h * 3 && x2 >= 0 && y2 >= 0)
            {
                if (x2 >= h && x2 <= h * 2)
                {
                    if (y2 <= h * 4)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
                else if (x2 <= h || x2 >= h * 2 && x2 <= h * 3)
                {
                    if (y2 <= h)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
            }
            else
                Console.WriteLine("outside");

            //проверка за x3
            if (x3 <= h * 3 && x3 >= 0 && y3 >= 0)
            {
                if (x3 >= h && 3 <= h * 2)
                {
                    if (y3 <= h * 4)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
                else if (x3 <= h || x3 >= h * 2 && x3 <= h * 3)
                {
                    if (y3 <= h)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
            }
            else
                Console.WriteLine("outside");

            //проверка за x4
            if (x4 <= h * 3 && x4 >= 0 && y4 >= 0)
            {
                if (x4 >= h && x4 <= h * 2)
                {
                    if (y4 <= h * 4)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
                else if (x4 <= h || x4 >= h * 2 && x4 <= h * 3)
                {
                    if (y4 <= h)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
            }
            else
                Console.WriteLine("outside");

            //проверка за x5
            if (x5 <= h * 3 && x5 >= 0 && y5 >= 0)
            {
                if (x5 >= h && x5 <= h * 2)
                {
                    if (y5 <= h * 4)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
                else if (x5 <= h || x5 >= h * 2 && x5 <= h * 3)
                {
                    if (y5 <= h)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                        Console.WriteLine("outside");
                }
            }
            else
                Console.WriteLine("outside");

            Console.ReadLine();
            //81 oт 100
        }
    }
}
