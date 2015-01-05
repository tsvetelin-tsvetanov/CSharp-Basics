using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MorseCodeNumbers
{
    class MorseCode
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int nSum = 0;
            //fourth digit
            int fourth = num % 10;
            //third
            int thirdTemp = num / 10;
            int third = thirdTemp % 10;
            //second
            int secondTemp = num / 100;
            int second = secondTemp % 10;
            //first
            int firstTemp = num / 1000;
            int first = firstTemp % 10;
            //sum
            nSum = first + fourth + second + third;
            //string of the morse code
            string zero = new string('-', 5);
            string one = new string('.', 1) + new string ('-', 4);
            string two = new string('.', 2) + new string ('-', 3);
            string three = new string('.', 3) + new string ('-', 2);
            string four = new string('.', 4) + new string('-', 1);
            string five = new string('.', 5);
            int count = 0;

            for (int a = 0; a < 6; a++ )
            {
                for(int b = 0; b < 6; b++)
                {
                    for(int c = 0; c < 6; c++)
                    {
                        for(int d = 0; d < 6; d++)
                        {
                            for(int e = 0; e < 6; e++)
                            {
                                for(int f = 0; f < 6; f++)
                                {
                                    int check = a * b * c * d * e * f;
                                    if(check == nSum)
                                    {
                                        switch(a)
                                        {
                                            case 0:
                                                Console.Write(zero + "|");
                                                break;
                                            case 1:
                                                Console.Write(one + "|");
                                                break;
                                            case 2:
                                                Console.Write(two + "|");
                                                break;
                                            case 3:
                                                Console.Write(three + "|");
                                                break;
                                            case 4:
                                                Console.Write(four + "|");
                                                break;
                                            case 5:
                                                Console.Write(five + "|");
                                                break;
                                        }
                                        switch (b)
                                        {
                                            case 0:
                                                Console.Write(zero + "|");
                                                break;
                                            case 1:
                                                Console.Write(one + "|");
                                                break;
                                            case 2:
                                                Console.Write(two + "|");
                                                break;
                                            case 3:
                                                Console.Write(three + "|");
                                                break;
                                            case 4:
                                                Console.Write(four + "|");
                                                break;
                                            case 5:
                                                Console.Write(five + "|");
                                                break;
                                        }
                                        switch (c)
                                        {
                                            case 0:
                                                Console.Write(zero + "|");
                                                break;
                                            case 1:
                                                Console.Write(one + "|");
                                                break;
                                            case 2:
                                                Console.Write(two + "|");
                                                break;
                                            case 3:
                                                Console.Write(three + "|");
                                                break;
                                            case 4:
                                                Console.Write(four + "|");
                                                break;
                                            case 5:
                                                Console.Write(five + "|");
                                                break;
                                        }
                                        switch (d)
                                        {
                                            case 0:
                                                Console.Write(zero + "|");
                                                break;
                                            case 1:
                                                Console.Write(one + "|");
                                                break;
                                            case 2:
                                                Console.Write(two + "|");
                                                break;
                                            case 3:
                                                Console.Write(three + "|");
                                                break;
                                            case 4:
                                                Console.Write(four + "|");
                                                break;
                                            case 5:
                                                Console.Write(five + "|");
                                                break;
                                        }
                                        switch (e)
                                        {
                                            case 0:
                                                Console.Write(zero + "|");
                                                break;
                                            case 1:
                                                Console.Write(one + "|");
                                                break;
                                            case 2:
                                                Console.Write(two + "|");
                                                break;
                                            case 3:
                                                Console.Write(three + "|");
                                                break;
                                            case 4:
                                                Console.Write(four + "|");
                                                break;
                                            case 5:
                                                Console.Write(five + "|");
                                                break;
                                        }
                                        switch (f)
                                        {
                                            case 0:
                                                Console.Write(zero + "|");
                                                break;
                                            case 1:
                                                Console.Write(one + "|");
                                                break;
                                            case 2:
                                                Console.Write(two + "|");
                                                break;
                                            case 3:
                                                Console.Write(three + "|");
                                                break;
                                            case 4:
                                                Console.Write(four + "|");
                                                break;
                                            case 5:
                                                Console.Write(five + "|");
                                                break;
                                        }
                                        Console.WriteLine();
                                        count++;
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
