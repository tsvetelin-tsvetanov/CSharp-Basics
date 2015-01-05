using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:\n1.Int\n2.Double\n3.String");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.Write("Enter a integer number: ");
                    int a = int.Parse(Console.ReadLine());
                    ++a;
                    Console.WriteLine("Your result: {0}", a);
                    break;
                case "2":
                    Console.Write("Enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    ++b;
                    Console.WriteLine("Your result: {0}", b);
                    break;
                case "3":
                    Console.WriteLine("Enter a string: ");
                    string c = Console.ReadLine();
                    object userString = c + "*";
                    Console.WriteLine(userString);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
