using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersInGivenInteger
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of the random numbers: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max: ");
            int max = int.Parse(Console.ReadLine());
            bool inRange = max >= min;
            if(inRange)
            {
                max += 1;
                Random randomGenerator = new Random();
                for(int i = 0; i<count;i++ )
                {
                    int randomNumber = randomGenerator.Next(min, max);
                    Console.Write(randomNumber + " "); 
                }
            }
            else
                Console.WriteLine("Invalid input");
            Console.ReadLine();
        }
    }
}
