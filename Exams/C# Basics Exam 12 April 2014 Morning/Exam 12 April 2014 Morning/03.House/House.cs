using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outsideDots = (n - 1) / 2; //при 9 = 4
            int insideDots = 1;

            for(int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    //i = 0 ... първи ред
                    string roof = new string('.', outsideDots);
                    Console.WriteLine(roof + '*' + roof);
                    outsideDots--;
                }
                else if(i < n / 2)
                {
                    //за 9 : i < 9 / 2 = 5
                    //1, 2, 3, 4 < 5
                    string outsideDot = new string('.', outsideDots);
                    string insideDot = new string('.', insideDots);
                    Console.WriteLine(outsideDot + '*' + insideDot + '*' + outsideDot);
                    outsideDots--;
                    insideDots += 2;
                }
                else if(i == ((n + 1) / 2))
                {
                    //за 9 : i == (9 + 1 / 2) = 5
                    //i = 5
                    string roofStart = new string('*', n);
                    Console.WriteLine(roofStart);
                    outsideDots = n / 4;
                    insideDots = n - 2 - (n / 4);
                }
                else if(i <= n - 1 && i > (n+1)/2)
                {
                    string outside = new string('.', n / 4);
                    string inside = new string('.', n - 2 - ((n/4)*2)); 
                    Console.WriteLine(outside + '*' + inside + '*' + outside);
                }

            }
            string outsideFinal = new string('.', n / 4);
            string insideFinal = new string('*', n - 2 - ((n / 4) * 2));
            Console.WriteLine(outsideFinal + '*' + insideFinal + '*' + outsideFinal);
            Console.ReadLine(); 
            //100 oт 100
            //дотук 275 от 500
        }
    }
}
