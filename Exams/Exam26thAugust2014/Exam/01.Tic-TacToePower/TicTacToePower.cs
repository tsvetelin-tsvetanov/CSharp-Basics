using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Tic_TacToePower
{
    class TicTacToePower
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            int index = 0;
            int count = 0;
            double result = 0;

            int i1 = value;
            int i2 = value + 1;
            int i3 = value + 2;
            int i4 = value + 3;
            int i5 = value + 4;
            int i6 = value + 5;
            int i7 = value + 6;
            int i8 = value + 7;
            int i9 = value + 8;

            if(x == 0 && y == 0)
            {
                index = i1;
                count = 1;
            }
            else if(x == 1 && y == 0)
            {
                index = i2;
                count = 2;
            }
            else if(x == 2 && y == 0)
            {
                index = i3;
                count = 3;
            }
            else if(x == 0 && y == 1)
            {
                index = i4;
                count = 4;
            }
            else if(x == 1 && y == 1)
            {
                index = i5;
                count = 5;
            }
            else if(x == 2 && y == 1)
            {
                index = i6;
                count = 6;
            }
            else if(x == 0 && y== 2)
            {
                index = i7;
                count = 7;
            }
            else if(x == 1 && y == 2)
            {
                index = i8;
                count = 8;
            }
            else if(x == 2 && y == 2)
            {
                index = i9;
                count = 9;
            }

            result = Math.Pow(index, count);
            Console.WriteLine((BigInteger)result);

            Console.ReadLine();
        }
    }
}
