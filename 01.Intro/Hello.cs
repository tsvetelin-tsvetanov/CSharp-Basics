using System;

namespace _01.Intro
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select solution [1-9]:");
            Console.WriteLine("1: Write \"Hello World!\"");
            Console.WriteLine("2: Write \"Добър ден!\"");
            Console.WriteLine("3: Write your name");
            Console.WriteLine("4: Write numbers 1, 101 and 1001 on separate rows");
            Console.WriteLine("5: Get current date and time");
            Console.WriteLine("6: Get square root of a number");
            Console.WriteLine("7: Get first 100 numbers in \"2, -3, 4, -5...\"");
            Console.WriteLine("8: Get your age after 10 years");
            Console.WriteLine("9: Exit the program");


            while (true)
            { 
                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Hello World!");
                        break;
                    case 2:
                        Console.WriteLine("Добър ден!");
                        break;
                    case 3:
                        Console.Write("Please enter your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Your name is " + name + "!");
                        break;
                    case 4:
                        Console.WriteLine(1);
                        Console.WriteLine(101);
                        Console.WriteLine(1001);
                        break;
                    case 5:
                        Console.WriteLine(DateTime.Now);
                        break;
                    case 6:
                        Console.WriteLine("Please enter a number: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Square root of " + n + " is: " + Math.Sqrt(n));
                        break;
                    case 7:
                        for(int i = 0; i < 100; i+=2)
                        {
                            Console.Write(i + 2 + " ");
                            Console.Write((i + 3) * -1 + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine("Please enter your age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Your age after 10 years will be: " + (age + 10));
                        break;
                    case 9:
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("This option is not available. Please try again.");
                        break;
                }
                Console.WriteLine("Please select an option:");
            }
        }
    }
}
