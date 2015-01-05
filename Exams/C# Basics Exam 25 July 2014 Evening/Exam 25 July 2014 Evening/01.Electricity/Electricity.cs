using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Electricity
{
    class Electricity
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());

            decimal lamp = 100.53m;
            decimal pc = 125.90m;
            decimal result = 0;
            TimeSpan hour = TimeSpan.Parse(Console.ReadLine());

            TimeSpan firstStart = new TimeSpan(14, 00, 00); 
            TimeSpan firstEnd = new TimeSpan(18, 59, 00);
            TimeSpan secondStart = new TimeSpan(19, 00, 00);
            TimeSpan secondEnd = new TimeSpan(23, 59, 00);
            TimeSpan thirdStart = new TimeSpan(0, 0, 0);
            TimeSpan thirdEnd = new TimeSpan(8, 59, 0);

            if(hour >= firstStart && hour <= firstEnd)
            {
                result = (((2 * lamp) + (2 * pc)) * flats) * floors;
                Console.WriteLine((int)result + " Watts");
            }
            else if(hour >= secondStart && hour <= secondEnd)
            {
                result = (((7 * lamp) + (6 * pc)) * flats) * floors;
                Console.WriteLine((int)result + " Watts");
            }
            else if(hour >= thirdStart && hour <= thirdEnd)
            {
                result = (((1 * lamp) + (8 * pc)) * flats) * floors;
                Console.WriteLine((int)result + " Watts");
            }
            else
            {
                Console.WriteLine((int)result + " Watts");
            }

            Console.ReadLine();
        }
    }
}
