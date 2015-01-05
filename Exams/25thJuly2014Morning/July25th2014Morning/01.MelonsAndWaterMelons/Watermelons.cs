using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MelonsAndWaterMelons
{
    class Watermelons
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int melons = 0;
            int watermelons = 0;

            for(int i = 0; i < days; i++)
            {
                if(start > 7)
                {
                    start = start % 7;
                }
                else {}
                if(start == 1)
                {
                    watermelons += 1;
                }
                else if( start == 2)
                {
                    melons += 2;
                }
                else if(start == 3)
                {
                    melons += 1;
                    watermelons += 1;
                }
                else if(start == 4)
                {
                    watermelons += 2;
                }
                else if(start == 5)
                {
                    watermelons += 2;
                    melons += 2;
                }
                else if(start == 6)
                {
                    watermelons += 1;
                    melons += 2;
                }
                else { }
                start++;
            }
            if(watermelons == melons)
            {
                Console.WriteLine("Equal amount: {0}", melons);
            }
            else if(watermelons > melons)
            {
                watermelons -= melons;
                Console.WriteLine("{0} more watermelons", watermelons);
            }
            else
            {
                melons -= watermelons;
                Console.WriteLine("{0} more melons", melons);
            }
            Console.ReadLine();
        }
    }
}
