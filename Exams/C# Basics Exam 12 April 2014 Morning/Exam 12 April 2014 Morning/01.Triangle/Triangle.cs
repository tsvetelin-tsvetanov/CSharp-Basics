using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int bx = int.Parse(Console.ReadLine());
            int by = int.Parse(Console.ReadLine());
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());

            double ab = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            double bc = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));
            double ac = Math.Sqrt((cx - ax) * (cx - ax) + (cy - ay) * (cy - ay));

            bool triangle = (ab + bc > ac && ab + ac > bc && ac + bc > ab);

            if(triangle == false)
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", ab);
            }
            else
            {
                double p = (ab + bc + ac) / 2;
                double area = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}", area);
            }
            Console.ReadLine();
        }
    }
}
