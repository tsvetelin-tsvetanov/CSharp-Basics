using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ProgrammerDNA
{
    class ProgrammerDNA
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < n; i++)
            {

                if(i == 0 || i == count * 7)
                {
                    Console.WriteLine("..."+"{0}"+"...", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                }
                else if (i == 1 || i == (count * 7) + 1)
                {
                    Console.Write(".." + "{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}" + "..\n", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                }
                else if (i == 2 || i == (count * 7) + 2)
                {
                    Console.Write("." + "{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}" + ".\n", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                }
                else if (i == 3 || i == (count * 7) + 3)
                {
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                }
                else if (i == 4 || i == (count * 7) + 4)
                {
                    Console.Write("\n." + "{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}" + ".\n", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                }
                else if (i == 5 || i == (count * 7) + 5)
                {
                    Console.Write(".." + "{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    Console.Write("{0}" + "..\n", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                }
                else if (i == 6 || i == (count * 7) + 6)
                {
                    Console.WriteLine("..." + "{0}" + "...", letter);
                    if (letter == 'G')
                        letter = 'A';
                    else
                        letter++;
                    count++;
                }
            }
            Console.ReadLine();
        }
    }
}
