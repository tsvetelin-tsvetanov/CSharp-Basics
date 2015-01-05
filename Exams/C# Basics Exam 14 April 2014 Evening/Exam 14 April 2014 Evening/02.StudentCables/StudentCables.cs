using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentCables
{
    class StudentCables
    {
        static void Main(string[] args)
        {
            int nCables = int.Parse(Console.ReadLine());
            int cableLength = 0;
            int count = 0;
            int anotherCount = 0;
            int totalCablesFirst = 0;
            int tempLength = 0;


            for(int i = 0; i < nCables; i++)
            {
                int cable = int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if(measure == "meters")
                {
                    cable *= 100;
                }
                if (cable < 20)
                    continue;
                cableLength += cable;
                anotherCount++;
            }
            totalCablesFirst = cableLength - ((anotherCount - 1) * 3);
            while(totalCablesFirst > 504)
            {
                tempLength += 504;
                totalCablesFirst -= 504;
                count++;
            }
            Console.WriteLine(count);
            Console.WriteLine(totalCablesFirst);
            Console.ReadLine();


        }
    }
}
//80 oт 100 
//дотук 161 от 500 
