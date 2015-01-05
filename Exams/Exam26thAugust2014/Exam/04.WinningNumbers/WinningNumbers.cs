using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.WinningNumbers
{
    class WinningNumbers
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            BigInteger sum = 0;
            for(int i = 0; i < letters.Length; i++)
            {
                char check = letters[i];
                if(check == 'a' || check == 'A')
                {
                    sum+=1;
                }
                else if(check == 'b' || check == 'B')
                {
                    sum += 2;
                }
                else if(check == 'c' || check == 'C')
                {
                    sum += 3;
                }
                else if(check == 'd' || check == 'D')
                {
                    sum += 4;
                }
                else if(check == 'e' || check == 'E')
                {
                    sum += 5;
                }
                else if(check == 'f' || check == 'F')
                {
                    sum += 6;
                }
                else if(check == 'g' || check == 'G')
                {
                    sum += 7;
                }
                else if(check == 'h' || check == 'H')
                {
                    sum += 8;
                }
                else if(check == 'i' || check == 'I')
                {
                    sum += 9;
                }
                else if(check == 'j' || check == 'J')
                {
                    sum += 10;
                }
                else if(check == 'k' || check == 'K')
                {
                    sum += 11;
                }
                else if(check == 'l' || check == 'L')
                {
                    sum += 12;
                }
                else if(check == 'm' || check == 'M')
                {
                    sum += 13;
                }
                else if(check == 'n' || check == 'N')
                {
                    sum += 14;
                }
                else if(check == 'o' || check == 'O')
                {
                    sum += 15;
                }
                else if(check == 'p' || check == 'P')
                {
                    sum += 16;
                }
                else if(check == 'q' || check == 'Q')
                {
                    sum += 17;
                }
                else if(check == 'r' || check == 'R')
                {
                    sum += 18;
                }
                else if(check == 's' || check == 'S')
                {
                    sum += 19;
                }
                else if(check == 't'|| check == 'T')
                {
                    sum += 20;
                }
                else if(check == 'u' || check == 'U')
                {
                    sum += 21;
                }
                else if(check == 'v' || check == 'V')
                {
                    sum += 22;
                }
                else if(check == 'w' || check == 'W')
                {
                    sum += 23;
                }
                else if(check == 'x' || check == 'X')
                {
                    sum += 24;
                }
                else if(check == 'y' || check == 'Y')
                {
                    sum += 25;
                }
                else if(check == 'z' || check == 'Z')
                {
                    sum += 26;
                }
                else
                {
                    sum += 0;
                }
           }

            for (int a = 1; a < 10; a++ )
            {
                for(int b = 1; b < 10; b++)
                {
                    for(int c = 1; c < 10; c++)
                    {
                        for(int d = 1; d < 10; d++)
                        {
                            for (int e = 1; e < 10; e++)
                            {
                                for(int f = 1; f < 10; f++)
                                {
                                    if ((a * b * c) == (d * e * f))
                                    {
                                        if ((a * b * c) == sum && (d * e * f) == sum)
                                        {
                                            Console.WriteLine("{0}{1}{2}-{3}{4}{5}", a, b, c, d, e, f);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

                Console.ReadLine();
        }
    }
}
