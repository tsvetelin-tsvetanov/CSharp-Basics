using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExamSchedule
{
    class ExamSchedule
    {
        static void Main(string[] args)
        {
            int startHours = int.Parse(Console.ReadLine());
            int startMinute = int.Parse(Console.ReadLine());
            string amPm = Console.ReadLine();
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());

            if(amPm == "PM")
            {
                startHours += 12;
                if(startHours == 24)
                {
                    startHours = 0; 
                }
            }

            DateTime start = new DateTime(2014, 08, 22, startHours, startMinute, 0);
            DateTime exam = start.AddHours(examHours).AddMinutes(examMinutes);
            Console.WriteLine("{0:hh:mm:tt}", exam);
            Console.ReadLine();
            //не знам защо ми даде 100 от 100, при мен не принти АМ/ПМ
            //може би проблема е от мен...
        }
    }
}
