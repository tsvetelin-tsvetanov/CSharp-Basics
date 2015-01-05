using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MagicDates
{
    class MagicDates
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());
            int count = 0;

            DateTime start = new DateTime(startYear, 01, 01);
            DateTime end = new DateTime(endYear, 12, 31);

            while(start < end)
            {

                int day = start.Day;
                int month = start.Month;
                int year = start.Year;
                int dayOne = day / 10;
                int dayTwo = day % 10;
                int monthOne = month / 10;
                int monthTwo = month % 10;
                int firstNumber = (year / 1000) % 10;
                int secondNumber = (year / 100) % 10;
                int thirdNumber = (year / 10) % 10;
                int currentWeight = 0;
                int fourthNumber = year % 10;
                int[] days = { dayOne, dayTwo, monthOne, monthTwo, firstNumber, secondNumber, thirdNumber, fourthNumber };
                for(int a = 0; a < days.Length; a++)
                {
                    for(int b = a + 1; b < days.Length; b++)
                    {
                        currentWeight = currentWeight + (days[a] * days[b]); ;
                    }
                }

                if (currentWeight == magicWeight)
                {
                    Console.WriteLine("{0:d2}-{1:d2}-{2:d2}", start.Day, start.Month, start.Year);
                    start = start.AddDays(1);
                    count++;
                }
                else
                    start = start.AddDays(1);
            }
            if(count == 0)
                Console.WriteLine("No");
            Console.ReadLine();
            //100 oт 100
            //дотук 375 от 500
        }
    }
}
