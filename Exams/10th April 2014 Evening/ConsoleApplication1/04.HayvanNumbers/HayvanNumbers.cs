﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HayvanNumbers
{
    class HayvanNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int count = 0;
            for(int a = 5; a < 10; a++)
            {
                for(int b = 5; b < 10; b++)
                {
                    for (int c = 5; c < 10; c++)
                    {
                        int abc = a * 100 + b * 10 + c;
                        for(int d = 5; d < 10; d++)
                        {
                            for (int e = 5; e < 10; e++)
                            {
                                for(int f = 5; f < 10; f++)
                                {
                                    int def = d * 100 + e * 10 + f;
                                    for(int g = 5; g < 10; g++)
                                    {
                                        for(int h = 5; h < 10; h++)
                                        {
                                            for(int i = 5; i < 10; i++)
                                            {
                                                int ghi = g * 100 + h * 10 + i;
                                                if(ghi - def == diff && def - abc == diff)
                                                {
                                                    if(a + b + c + d + e + f + g + h + i == sum)
                                                    {
                                                        if(abc < def && def < ghi)
                                                        {
                                                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", a, b, c, d, e, f, g, h, i);
                                                            count++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }
            if(count == 0)
                Console.WriteLine("No");
            Console.ReadLine();
        }
    }
}
//73 от 100 в Judge
