// 2. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
// that has maximal sum of its elements.

namespace PlatformWithMaxSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PlatformWithMaxSum
    {
        static void Main()
        {
            // declare and initialize the matrix
            Random rndGen = new Random();
            int rowCount = rndGen.Next(5, 10);
            int colCount = rndGen.Next(7, 15);

            int[,] matrix = new int[rowCount, colCount];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rndGen.Next(1, 50);
                }
            }

            // print the randomly generated matrix
            PrintMatrix(matrix);

            // find the platform 3x3 with maximum sum
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int sum = 0;

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum =
                        matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] +
                        matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine("".PadLeft(40, '-'));
            Console.WriteLine("The 3x3 platform with max sum of {0} is:", bestSum);
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write(matrix[row, col].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col].ToString().PadLeft(3, ' '));
                }

                Console.WriteLine();
            }
        }
    }
}
