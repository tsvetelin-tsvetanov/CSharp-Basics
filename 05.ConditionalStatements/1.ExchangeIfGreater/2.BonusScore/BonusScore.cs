using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your score between 1 and 9: ");
            int score = int.Parse(Console.ReadLine());
            if(score >=1 && score <=3)
            {
                score *= 10;
                Console.WriteLine(score);
            }
            else if (score >=4 && score <=6)
            {
                score *= 100;
                Console.WriteLine(score);
            }
            else if (score >= 7 && score <=9)
            {
                score *= 1000;
                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("Invalid Score");
            }
            Console.ReadLine();
        }
    }
}
