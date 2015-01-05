using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number for c: ");
            double c = double.Parse(Console.ReadLine());
            if(a != 0)
            {
                if(b!=0)
                {
                    if(c!=0)
                    {
                        double result = a * b * c;
                        if (result > 0)
                        {
                            Console.WriteLine("+");
                        }
                        else if(result <0)
                        {
                            Console.WriteLine("-");
                        }
                        else
                        {
                            Console.WriteLine("0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();
        }
    }
}
