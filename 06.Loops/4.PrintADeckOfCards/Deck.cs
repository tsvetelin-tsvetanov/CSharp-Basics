using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PrintADeckOfCards
{
    class Deck
    {
        static void Main(string[] args)
        {
            int club = 3;
            int diamond = 4;
            int heart = 5;
            int spade = 6;
            for(int i = 2; i < 15; i++)
            {
                if (i > 1 && i < 11)
                {
                    Console.WriteLine("{0}{1} {2}{3} {4}{5} {6}{7}", i, (char)club, i, (char)diamond, i,
                        (char)heart, i, (char)spade);
                }
                else
                {
                    for (int n = i; n < i + 1; n++)
                    {
                        switch (n)
                        {
                            case 11:
                                Console.WriteLine("J{0} J{1} J{2} J{3}", (char)club, (char)diamond,
                                    (char)heart, (char)spade);
                                break;
                            case 12:
                                Console.WriteLine("D{0} D{1} D{2} D{3}", (char)club, (char)diamond,
                                    (char)heart, (char)spade);
                                break;
                            case 13:
                                Console.WriteLine("K{0} K{1} K{2} K{3}", (char)club, (char)diamond,
                                    (char)heart, (char)spade);
                                break;
                            case 14:
                                Console.WriteLine("A{0} A{1} A{2} A{3}", (char)club, (char)diamond,
                                    (char)heart, (char)spade);
                                break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
