using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeTheNumbersFromOneToN
{
    class RandomizeNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < num; i++)
            {
                array[i] = i + 1;
            }
 
            Random random = new Random();
            foreach (int i in array)
            {
                int randNum = random.Next(0, num);
                int temp = array[randNum];
                array[randNum] = array[0];
                array[0] = temp;
            }
            Console.WriteLine(String.Join(" ", array));
        
            Console.ReadLine();
        }
    }
}
