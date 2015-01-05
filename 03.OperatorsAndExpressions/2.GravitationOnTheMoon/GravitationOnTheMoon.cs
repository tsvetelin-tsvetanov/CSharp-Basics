using System;
 class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
           //1kg on the moon weights 5,882352941176471kg on earth
            Console.WriteLine("Enter your weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());
            decimal difference = 5.882352941176471M;
            decimal MoonWeight = weight / difference;
            Console.WriteLine("Your weight on moon would be: {0}kg", MoonWeight);
            Console.ReadLine();
        }
    }

