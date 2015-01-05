using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());
            int availableWeekends = 48 - hometownWeekends; 
            double notAtWorkWeekends = availableWeekends * 3.0 / 4.0; //мачове през уикендите
            double holidayPlays = holidays * 2.0 / 3.0; // мачове през ваканциите
            double weekendsCount = hometownWeekends * 1.0;
            double total = notAtWorkWeekends + holidayPlays + hometownWeekends;
            if(leap == "leap")
            {
                total *= 1.15;
            }
            Console.WriteLine((int)total);
            Console.ReadLine(); ;
        }
    }
}
