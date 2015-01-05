using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 numbers\nFirst Number: ");
            int a = int.Parse(Console.ReadLine()); 
            Console.Write("Second Number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Third Number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Fourth Number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Fifth Number: ");
            int e = int.Parse(Console.ReadLine());
            bool check = true;
            if (check = true)
            {
                //two num combo
                if (a + b == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, b);
                }
                if (a + c == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, c);
                }
                if (a + d == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, d);
                }
                if (a + e == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, e);
                }
                if (b + c == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, c);
                }
                if (b + d == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, d);
                }
                if (b + e == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, e);
                }
                if (c + d == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", c, d);
                }
                if (c + e == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", c, e);
                }
                if (d + e == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", d, e);
                }
                //three num combo
                if (a + b + c == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
                }
                if (a + b + d == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
                }
                if (a + b + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
                }
                if (a + c + d == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
                }
                if (a + c + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
                }
                if (a + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
                }
                if (b + c + d == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
                }
                if (b + c + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
                }
                if (b + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
                }
                if (c + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
                }
                //four number combo
                if (a + b + c + d == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
                }
                if (a + b + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
                }
                if (a + c + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
                }
                if (b + c + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
                }
            }
            else
            {
                Console.WriteLine("No zero subset");
            }
            Console.ReadLine();
        }
    }
}
