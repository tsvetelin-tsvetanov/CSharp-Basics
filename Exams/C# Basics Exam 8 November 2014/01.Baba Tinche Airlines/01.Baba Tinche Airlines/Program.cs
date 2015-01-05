using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Baba_Tinche_Airlines
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstRow = Console.ReadLine();
            char firstA = firstRow[0];
            char firstB = firstRow[2];
            char firstC = firstRow[4];

            int firstClassA = (int)Char.GetNumericValue(firstA);
            int firstClassB = (int)Char.GetNumericValue(firstB);
            int firstClassC = (int)Char.GetNumericValue(firstC);
            int firstClassTotal = firstClassA + firstClassB + firstClassC;

            string secondRow = Console.ReadLine();
            char secondA = secondRow[0];
            char secondB = secondRow[2];
            char secondC = secondRow[4];

            int secondClassA = (int)Char.GetNumericValue(secondA);
            int secondClassB = (int)Char.GetNumericValue(secondB);
            int secondClassC = (int)Char.GetNumericValue(secondC);
            int secondClassTotal = secondClassA + secondClassB + secondClassC;

            string thirdRow = Console.ReadLine();
            char thirdA = thirdRow[0];
            char thirdB = thirdRow[2];
            char thirdC = thirdRow[4];

            int thirdClassA = (int)Char.GetNumericValue(thirdA);
            int thirdClassB = (int)Char.GetNumericValue(thirdB);
            int thirdClassC = (int)Char.GetNumericValue(thirdC);
            int thirdClassTotal = thirdClassA + thirdClassB + thirdClassC;

            int firstClassTickets = firstClassTotal * 7000;
            int secondClassTickets = secondClassTotal * 3500;
            int thirdClassTickets = thirdClassTotal * 1000;

            long ticketsMax = (12 * 7000) + (28 * 3500) + (50 * 1000);
            long ticketsSold = firstClassTickets + secondClassTickets + thirdClassTickets;
            long diff = ticketsMax - ticketsSold;

            Console.WriteLine(ticketsSold);
            Console.WriteLine(ticketsMax);

            Console.ReadLine();
        }
    }
}
