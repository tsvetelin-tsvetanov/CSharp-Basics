using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countAsterisk = 1;
            int countDash = ((n - 1)/2);

            for (int i = 0; i < (n + 1) / 2; i++ )
            {
                string dash = new string('-', countDash);
                string asterisk = new string('*', countAsterisk);
                Console.WriteLine(dash + asterisk + dash);
                countDash--;
                countAsterisk +=2;
            }
            countAsterisk = n - 2;
            for (int i = 0; i < n; i++ )
            {
                string asterisk = new string('*', countAsterisk);
                Console.WriteLine('|' + asterisk + '|');

            }

                Console.ReadLine();
            //дотук 300 от 500
        }
    }
}
