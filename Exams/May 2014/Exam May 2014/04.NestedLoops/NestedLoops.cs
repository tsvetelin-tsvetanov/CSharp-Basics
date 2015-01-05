using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NestedLoops
{
    class NestedLoops
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine()); ;
            int cows = int.Parse(Console.ReadLine());

            int count = 0;
            string result = "";


            //fourth digit
            int numD = number % 10;
            //third digit
            int thirdNumberCheck = number / 10;
            int numC = thirdNumberCheck % 10;
            //second digit
            int secondNumberCheck = number / 100;
            int numB = secondNumberCheck % 10;
            //first digit
            int firstNumberCheck = number / 1000;
            int numA = firstNumberCheck % 10;
            //sum of the digits

            for(int i = 1111; i < 9999; i++)
            {
                for(int a = 1; a < 10; a++)
                {
                    for(int b = 1; b < 10; b++)
                    {
                        for(int c = 1; c < 10; c++)
                        {
                            for(int d = 1; d < 10; d++)
                            {
                                switch(bulls)
                                {
                                    case 0:
                                        if (cows == 1)
                                        {
                                            if (numA == b || numA == c || numA == d || numB == a || numB == c || numB == d
                                                || numC == a || numC == b || numC == d || numD == a || numD == b || numD == c)
                                            {
                                                result += a + b + c + d + " ";
                                                count++;
                                            }
                                        }
                                        else if(cows == 2)
                                        {
                                            if (((numA != a && numA == b || numA == c || numA == d) &&
                                                (numB != b && numB == a || numB == c || numB == d)))
                                            {
                                                result += a + b + c + d + " ";
                                                count++;
                                            }
                                        }
                                    break;
                                }                          
                            }
                        }
                    }
                }
            }
            if(count == 0)
                Console.WriteLine("No");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
