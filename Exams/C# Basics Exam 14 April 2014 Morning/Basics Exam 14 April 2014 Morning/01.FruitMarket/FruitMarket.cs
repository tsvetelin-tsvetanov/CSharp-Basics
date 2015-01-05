using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FruitMarket
{
    class FruitMarket
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            decimal quantity1 = decimal.Parse(Console.ReadLine());
            string product1 = Console.ReadLine();
            decimal quantity2 = decimal.Parse(Console.ReadLine());
            string product2 = Console.ReadLine();
            decimal quantity3 = decimal.Parse(Console.ReadLine());
            string product3 = Console.ReadLine();
            decimal product11 = 0;
            decimal product22 = 0;
            decimal product33 = 0;
            decimal total = 0;

            decimal banana = 1.80M;
            decimal cucumber = 2.75M;
            decimal tomato = 3.20M;
            decimal orange = 1.60M;
            decimal apple = 0.86M;

            switch(product1)
            {
                case "banana": product11 = banana;
                    break;
                case "cucumber": product11 = cucumber;
                    break;
                case "tomato": product11 = tomato;
                    break;
                case "orange": product11 = orange;
                    break;
                case "apple": product11 = apple;
                    break;
            }

            switch (product2)
            {
                case "banana": product22 = banana;
                    break;
                case "cucumber": product22 = cucumber;
                    break;
                case "tomato": product22 = tomato;
                    break;
                case "orange": product22 = orange;
                    break;
                case "apple": product22 = apple;
                    break;
            }

            switch (product3)
            {
                case "banana": product33 = banana;
                    break;
                case "cucumber": product33 = cucumber;
                    break;
                case "tomato": product33 = tomato;
                    break;
                case "orange": product33 = orange;
                    break;
                case "apple": product33 = apple;
                    break;
            }

            if(day == "Monday" || day == "Saturday")
            {
                total = (product11 * quantity1)  + (product22 * quantity2)  + (product33 * quantity3);
                Console.WriteLine("{0:f2}", total);
            }
            else if(day == "Tuesday")
            {
                if (product1 == "banana" || product1 == "orange" || product1 == "apple")
                    product11 *= 0.80m;
                if (product2 == "banana" || product2 == "orange" || product2 == "apple")
                    product22 *= 0.80m;
                if (product3 == "banana" || product3 == "orange" || product3 == "apple")
                    product33 *= 0.80m;
                total = (product11 * quantity1) + (product22 * quantity2) + (product33 * quantity3);
                Console.WriteLine("{0:f2}", total);
            }
            else if(day == "Wednesday")
            {
                if (product1 == "tomato" || product1 == "cucumber")
                    product11 *= 0.90m;
                if (product2 == "tomato" || product2 == "cucumber")
                    product22 *= 0.90m;
                if (product3 == "tomato" || product3 == "cucumber")
                    product33 *= 0.90m;
                total = (product11 * quantity1) + (product22 * quantity2) + (product33 * quantity3);
                Console.WriteLine("{0:f2}", total);
            }
            else if(day == "Thursday")
            {
                if (product1 == "banana")
                    product11 *= 0.70m;
                if (product2 == "banana")
                    product22 *= 0.70m;
                if (product3 == "banana")
                    product33 *= 0.70m;
                total = (product11 * quantity1) + (product22 * quantity2) + (product33 * quantity3);
                Console.WriteLine("{0:f2}", total);
            }
            else if(day == "Friday")
            {
                total = ((product11 * 0.90m) * quantity1) + ((product22 * 0.90m) * quantity2) + ((product33 * 0.90m) * quantity3);
                Console.WriteLine("{0:f2}", total);
            }
            else if(day == "Sunday")
            {
                total = ((product11 * 0.95m) * quantity1) + ((product22 * 0.95m) * quantity2) + ((product33 * 0.95m) * quantity3);
                Console.WriteLine("{0:f2}", total);
            }
            Console.ReadLine();
            //100 от 100 
        }
    }
}
