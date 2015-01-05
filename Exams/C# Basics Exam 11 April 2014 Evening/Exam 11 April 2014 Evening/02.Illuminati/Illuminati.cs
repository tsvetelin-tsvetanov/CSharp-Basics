using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Illuminati
{
    class Illuminati
    {
        static void Main(string[] args)
        {
            int a = 65;
            int e = 69;
            int i = 73;
            int o = 79;
            int u = 85;

            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;

            string message = Console.ReadLine();

            for(int b = 0; b < message.Length; b++ )
            {
                char lastChar = message[b];
                if (lastChar == 'a' || lastChar == 'A')
                    countA++;
                else if (lastChar == 'e' || lastChar == 'E')
                    countE++;
                else if (lastChar == 'i' || lastChar == 'I')
                    countI++;
                else if (lastChar == 'o' || lastChar == 'O')
                    countO++;
                else if (lastChar == 'u' || lastChar == 'U')
                    countU++;
            }

            int vowels = countA + countE + countI + countO + countU;
            int sum = (countA * a) + (countE * e) + (countI * i) + (countO * o) + (countU * u);
            Console.WriteLine(vowels);
            Console.WriteLine(sum);
            Console.ReadLine(); 
            
        }
    }
}
