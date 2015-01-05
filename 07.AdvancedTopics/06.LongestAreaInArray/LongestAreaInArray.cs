using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];
            for(int i = 0; i < n; i++)
            {
                string newWord = Console.ReadLine();
                words[i] = newWord;
            }
            Console.WriteLine();
            int count = 0;
            int maxCount = 0;
            int index = 0;
            for (int i = 0; i < n - 1; i ++ )
            {
                if (words[i] == words[i + 1])
                {
                    count++;
                    if(maxCount < count)
                        maxCount = count;
                }
                else if(words[i] != words[i + 1] && maxCount < count)
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxCount);
            Console.ReadLine();
            //трябва да се довърши
        }
    }
}
