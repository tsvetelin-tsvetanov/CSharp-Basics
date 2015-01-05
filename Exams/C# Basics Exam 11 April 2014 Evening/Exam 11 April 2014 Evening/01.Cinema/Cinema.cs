using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            decimal total = 0;
            if(type == "Premiere")
            {
                total = (rows * columns) * 12.00m;
                Console.WriteLine(total + " leva");
            }
            else if(type == "Normal")
            {
                total = (rows * columns) * 7.50m;
                Console.WriteLine(total + " leva");
            }
            else if(type == "Discount")
            {
                total = (rows * columns) * 5.00m;
                Console.WriteLine(total + " leva");
            }
            Console.ReadLine();

        }
    }
}
