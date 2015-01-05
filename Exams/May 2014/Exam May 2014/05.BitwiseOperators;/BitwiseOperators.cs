using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitwiseOperators_
{
    class BitwiseOperators
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string num = Convert.ToString(n, 2);
            string [] numbers = num.Split(' ');
            string result = "0";
            Console.WriteLine(num);

            foreach (var i in numbers)
            {
                string temp = i;
                if(temp == "0")
                {
                    result += ' ' + '1' ;
                }
                else if(temp == "1")
                {
                    result += ' ' + '0';
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
