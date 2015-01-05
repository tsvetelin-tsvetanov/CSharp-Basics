using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MagicCarNumbers
{
    class MagicCarNumbers
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int tempE = 0;
            int tempF = 0;
            int result = 0;
            int count = 0;

            for(int a = 0; a <= 9; a++)
            {
                for(int b = 0; b <= 9; b++)
                {
                    for (int e = 1; e < 11; e++)
                    {
                        if (e == 1)
                            tempE = 10;
                        else if (e == 2)
                            tempE = 20;
                        else if (e == 3)
                            tempE = 30;
                        else if (e == 4)
                            tempE = 50;
                        else if (e == 5)
                            tempE = 80;
                        else if (e == 6)
                            tempE = 110;
                        else if (e == 7)
                            tempE = 130;
                        else if (e == 8)
                            tempE = 160;
                        else if (e == 9)
                            tempE = 200;
                        else if (e == 10)
                            tempE = 240;
                        for (int f = 1; f < 11; f++)
                        {
                            if (f == 1)
                                tempF = 10;
                            else if (f == 2)
                                tempF = 20;
                            else if (f == 3)
                                tempF = 30;
                            else if (f == 4)
                                tempF = 50;
                            else if (f == 5)
                                tempF = 80;
                            else if (f == 6)
                                tempF = 110;
                            else if (f == 7)
                                tempF = 130;
                            else if (f == 8)
                                tempF = 160;
                            else if (f == 9)
                                tempF = 200;
                            else if (f == 10)
                                tempF = 240;


                            
                            if (b != a)
                            {
                                if (30 + 10 + a + a + a + a + tempE + tempF == weight)
                                    count++;
                                else if (30 + 10 + a + b + b + b + tempE + tempF == weight)
                                    count++;
                                else if (30 + 10 + a + a + a + b + tempE + tempF == weight)
                                    count++;
                                else if (30 + 10 + a + a + b + b + tempE + tempF == weight)
                                    count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}

//60 от 100
//дотук 241 от 500