using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FiveSpecialLetters
{
    class FiveLetters
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int count = 0;

            int letterA = 5;
            int letterB = -12;
            int letterC = 47;
            int letterD = 7;
            int letterE = -32;
            int wordWeight = 0;

            for(int a = 'a'; a <= 'e'; a++)
            {
                for(int b = 'a'; b <= 'e'; b++)
                {
                    for (int c = 'a'; c <= 'e'; c++)
                    {
                        for(int d = 'a'; d <= 'e'; d++)
                        {
                            for(int e = 'a'; e <= 'e'; e++)
                            {
                                string tempA = Convert.ToString(a);
                                string tempB = Convert.ToString(b);
                                string tempC = Convert.ToString(c);
                                string tempD = Convert.ToString(d);
                                string tempE = Convert.ToString(e);
                                string tempWord = tempA + tempB + tempC + tempD + tempE;
                                switch(a)
                                {
                                    case 'a': a = letterA;
                                        break;
                                    case 'b': a = letterB;
                                        break;
                                    case 'c': a = letterC;
                                        break;
                                    case 'd': a = letterD;
                                        break;
                                    case 'e': a = letterE;
                                        break;
                                }
                                switch (b)
                                {
                                    case 'a': b = letterA;
                                        break;
                                    case 'b': b = letterB;
                                        break;
                                    case 'c': b = letterC;
                                        break;
                                    case 'd': b = letterD;
                                        break;
                                    case 'e':b = letterE;
                                        break;
                                }
                                switch (c)
                                {
                                    case 'a': c = letterA;
                                        break;
                                    case 'b': c = letterB;
                                        break;
                                    case 'c': c = letterC;
                                        break;
                                    case 'd': c = letterD;
                                        break;
                                    case 'e': c = letterE;
                                        break;
                                }
                                switch (d)
                                {
                                    case 'a': d = letterA;
                                        break;
                                    case 'b': d = letterB;
                                        break;
                                    case 'c': d = letterC;
                                        break;
                                    case 'd': d = letterD;
                                        break;
                                    case 'e': d = letterE;
                                        break;
                                }
                                switch (e)
                                {
                                    case 'a': e = letterA;
                                        break;
                                    case 'b': e = letterB;
                                        break;
                                    case 'c': e = letterC;
                                        break;
                                    case 'd': e = letterD;
                                        break;
                                    case 'e': e = letterE;
                                        break;
                                }
                                wordWeight = a + b + c + d + e;
                                if (wordWeight >= start && wordWeight <= end)
                                {
                                    Console.WriteLine(tempWord);
                                    count++;
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
