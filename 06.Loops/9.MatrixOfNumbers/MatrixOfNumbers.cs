using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number 'n' in the range 1 <= n <= 20: ");
            int n = int.Parse(Console.ReadLine());
            if(n > 0 && n < 21)
            {
                int[,] matrix = new int[n, n];
                for(int row = 0; row < n; row++)
                {
                    for(int col = 0; col<n; col++)
                    {
                        if(row > 0)
                        {
                            matrix[row, col] = matrix[row - 1, col] + 1;
                        }
                        else
                        {
                            matrix[row, col] = col + 1;
                        }
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }
}
