using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.X_Bits
{
    class XBits
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int six = int.Parse(Console.ReadLine());
            int seven = int.Parse(Console.ReadLine());
            int eight = int.Parse(Console.ReadLine());

            string first = Convert.ToString(one, 2).PadLeft(32, '0');
            string second = Convert.ToString(two, 2).PadLeft(32, '0');
            string third = Convert.ToString(three, 2).PadLeft(32, '0');
            string fourth = Convert.ToString(four, 2).PadLeft(32, '0');
            string fifth = Convert.ToString(five, 2).PadLeft(32, '0');
            string sixth = Convert.ToString(six, 2).PadLeft(32, '0');
            string seventh = Convert.ToString(seven, 2).PadLeft(32, '0');
            string eigthth = Convert.ToString(eight, 2).PadLeft(32, '0');

            int count = 0;

            for (int i = 0; i < first.Length; i++ )
            {
                if(first[i] == '1' && i < first.Length - 2 && first[i+1] == '0')
                {
                    if(first[i + 2] == '1')
                    {
                        if(second[i + 1] == '1' && second[i] == '0' && second[i+2] == '0')
                        {
                            if(third[i] == '1'&& third[i+1] == '0')
                            {
                                if(third[i + 2] == '1')
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            for(int i = 0; i < second.Length; i++)
            {
                if (second[i] == '1' && i < first.Length - 2 && second[i+1] == '0')
                {
                    if(second[i+2] == '1')
                    {
                        if(third[i+1] == '1' && third[i] == '0' && third[i+2] == '0')
                        {
                            if(fourth[i] == '1' && fourth[i+1] == '0')
                            {
                                if(fourth[i+2] == '1')
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
           for(int i = 0; i < third.Length; i++)
           {
               if (third[i] == '1' && i < first.Length - 2 && third[i+1] == '0')
               {
                   if(third[i+2] == '1')
                   {
                       if(fourth[i+1] == '1' && fourth[i] == '0' && fourth[i+2] == '0')
                       {
                           if(fifth[i] == '1' && fifth[i+1] == '0')
                           {
                               if(fifth[i+2] == '1')
                               {
                                   count++;
                               }
                           }
                       }
                   }
               }
           }
            for(int i = 0; i < fourth.Length; i++)
            {
                if (fourth[i] == '1' && i < first.Length - 2 && fourth[i+1] == '0')
                {
                    if (fourth[i + 2] == '1')
                    {
                        if (fifth[i + 1] == '1' && fifth[i] == '0' && fifth[i+2] == '0')
                        {
                            if (sixth[i] == '1' && sixth[i+1] == '0')
                            {
                                if (sixth[i + 2] == '1')
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            for(int i = 0; i < fifth.Length ; i++)
            {
                if (fifth[i] == '1' && i < first.Length - 2 && fifth[i+1] == '0')
                {
                    if(fifth[i+2] == '1')
                    {
                        if(sixth[i+1] == '1' && sixth[i] == '0' && sixth[i+2] == '0')
                        {
                            if(seventh[i] == '1' && seventh[i+1] == '0')
                            {
                                if(seventh[i+2] == '1')
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            for(int i = 0; i < sixth.Length; i++)
            {
                if (sixth[i] == '1' && i < first.Length - 2 && sixth[i+1] == '0')
                {
                    if(sixth[i+2] == '1')
                    {
                        if(seventh[i+1] == '1' && seventh[i] == '0' && seventh[i+2] == '0')
                        {
                            if(eigthth[i] == '1' && eigthth[i+1] == '0')
                            {
                                if(eigthth[i+2] == '1')
                                {
                                    count++;
                                }
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
