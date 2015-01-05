using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.LettersSymbolsNumbers
{
    class LettersSymbolsNumbers
    {
        static void Main(string[] args)
        {
            int numOfStrings = int.Parse(Console.ReadLine());
            int lettersSum = 0;
            int numbersSum = 0;
            int symbolsSum = 0;

            for(int i = 0; i < numOfStrings; i ++)
            {
                string input = Console.ReadLine();
                input = input.ToUpper();
                input = Regex.Replace(input, "\\s+", "");
                for(int a = 0; a < input.Length; a++)
                {
                    char current = input[a];
                    if(current >= 'A' && current <= 'Z')
                    {
                        lettersSum += (current - 'A' + 1) * 10;
                    }
                    else if(current >= '0' && current <= '9' )
                    {
                        numbersSum += (current - '0') * 20;
                    }
                    else
                    {
                        symbolsSum += 200;
                    }
                }

            }
            Console.WriteLine(lettersSum);
            Console.WriteLine(numbersSum);
            Console.WriteLine(symbolsSum);
            Console.ReadLine();
        }
    }
}
