using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddAndEvenJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());

            string oddLetters = word[0] + " " ;
            string evenLetters = word [1] + " ";

            for(int i = 2; i < word.Length; i++)
            {
                char letter = word[i];
                if(i % 2 == 0)
                {
                    oddLetters += letter + " ";
                }
                else
                {
                    evenLetters += letter + " ";
                }
            }


        }
    }
}
