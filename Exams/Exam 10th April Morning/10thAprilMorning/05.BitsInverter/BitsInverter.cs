using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitsInverter
{
    class BitsInverter
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder stringofbyte = new System.Text.StringBuilder();
            int n = Int32.Parse(Console.ReadLine());
            int step = Int32.Parse(Console.ReadLine());

            string bitString = Convert.ToString(n, 2).PadLeft(32,'0');
            char lastChar = bitString[0];


            for(int i = 0; i < bitString.Length; i++)
            {
                if (stringofbyte[i] == (char)48)
                {
                    stringofbyte[k] = (char)49;
                }
                else
                {
                    stringofbyte[k] = (char)48;
                }
            }

            int result = Convert.ToInt32(bitString, 10);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

//трябва да се оправи, като качат примерите от 19.08 ще я погледдна пак;
