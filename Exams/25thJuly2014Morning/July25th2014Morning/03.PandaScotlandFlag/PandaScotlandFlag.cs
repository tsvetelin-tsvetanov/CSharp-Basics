using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PandaScotlandFlag
{
    class PandaScotlandFlag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letterOne = 'A';
            int hashtagCount = n - 2;
            int waveCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    string hashtag = new string('#', hashtagCount);
                    Console.Write(letterOne + hashtag);
                    letterOne++;
                    Console.Write(letterOne + "\n");
                    waveCount++;
                    hashtagCount -= 2;
                }
                else if (i < (n - 1) / 2)
                {
                    string wave = new string('~', waveCount);
                    string hashtag = new string('#', hashtagCount);
                    if (letterOne == 'Z')
                        letterOne = 'A';
                    else
                        letterOne++;
                    Console.Write(wave + letterOne + hashtag);
                    if (letterOne == 'Z')
                        letterOne = 'A';
                    else
                        letterOne++;
                    Console.Write(letterOne + wave + "\n");
                    waveCount++;
                    hashtagCount -= 2;
                }
                else if (i == (n - 1) / 2)
                {
                    string dash = new string('-', waveCount);
                    if (letterOne == 'Z')
                        letterOne = 'A';
                    else
                        letterOne++;
                    Console.Write(dash + letterOne);
                    Console.Write(dash + "\n");
                    hashtagCount += 2;
                    waveCount--;
                }
                else if (i > (n - 1) / 2)
                {
                    string wave = new string('~', waveCount);
                    string hashtag = new string('#', hashtagCount);
                    if (letterOne == 'Z')
                        letterOne = 'A';
                    else
                        letterOne++;
                    Console.Write(wave + letterOne + hashtag); 
                    if (letterOne >= 'Z')
                        letterOne = 'A';
                    else
                        letterOne++;
                    Console.Write(letterOne + wave + "\n");
                    waveCount--;
                    hashtagCount += 2;
                }

            }
            Console.ReadLine();
            //90 oт 100
        }
    }
}
