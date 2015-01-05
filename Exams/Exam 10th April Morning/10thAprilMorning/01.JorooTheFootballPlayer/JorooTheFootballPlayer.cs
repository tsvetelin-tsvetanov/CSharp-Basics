using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.JorooTheFootballPlayer
{
    class JorooTheFootballPlayer
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());
            double holidayPlays = holidays / 2.0;
            double playWeekends = (52 - hometownWeekends) * 2.0 / 3.0;
            double total = playWeekends + holidayPlays + hometownWeekends;
            if(leap == "t")
            {
                total += 3;
            }
            Console.WriteLine((int)total);
            Console.ReadLine();
        }
    }
}
