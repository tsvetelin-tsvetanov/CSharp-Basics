﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FitBoxInBox
{
    class FirBoxInBox
    {
        static void Main(string[] args)
        {
            int w1 = int.Parse(Console.ReadLine());
            int h1 = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());
            int w2 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());

            //if a > b
            if (w1 < w2 && h1 < h2 && d1 < d2)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, h2, d2);
            }
            if (w1 < h2 && h1 < w2 && d1 < d2)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, h2, w2, d2);
            }
            if (w1 < w2 && h1 < d2 && d1 < h2)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, d2, h2);
            }
            if (w1 < h2 && h1 < d2 && d1 < w2)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, h2, d2, w2);
            }
            if (w1 < d2 && h1 < w2 && d1 < h2)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, d2, w2, h2);
            }
            if (w1 < d2 && h1 < h2 && d1 < w2)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, d2, h2, w2);
            }
            //if b > a
            if (w2 < w1 && h2 < h1 && d2 < d1)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, w1, h1, d1);
            }
            if (w2 < h1 && h2 < w1 && d2 < d1)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, h1, w1, d1);
            }
            if (w2 < w1 && h2 < d1 && d2 < h1)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, w1, d1, h1);
            }
            if (w2 < h1 && h2 < d1 && d2 < w1)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, h1, d1, w1);
            }
            if (w2 < d1 && h2 < w1 && d2 < h1)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, d1, w1, h1);
            }
            if (w2 < d1 && h2 < h1 && d2 < w1)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, d1, h1, w1);
            }
            Console.ReadLine();
        }
    }
}
