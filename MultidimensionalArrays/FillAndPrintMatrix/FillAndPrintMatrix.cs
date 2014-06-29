// 1. Write a program that fills and prints a matrix of size (n, n) as shown below: 
/* a)  1  5  9   13    b)  1  8  9  16   c) 7  11  14  16  *d) 1 12 11 10
       2  6  10  14        2  7  10 15      4  8   12  15      2 13 16 9
       3  7  11  15        3  6  11 14      2  5   9   13      3 14 15 8
       4  8  12  16        4  5  12 13      1  3   6   10      4 5  6  7 */

namespace FillAndPrintMatrix
{
    using System;
    using System.Linq;

    class FillAndPrintMatrix
    {
        private static int n;
        private static int[,] matrix;

        private static void Main()
        {
            // enter the number of elements n
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            matrix = new int[n, n];

            // subsection a)
            Console.WriteLine("Subsection a)");
            MatrixIncreasingColumns();

            // subsection b)
            Console.WriteLine("Subsection b)");
            MatrixIncreasingAndDecreasingColumns();

            // subsection c)
            Console.WriteLine("Subsection c)");
            MatrixDiagonallyAssigned();

            // subsection d)*
            Console.WriteLine("Subsection *d)");
            SpiralMatrix();
        }

        private static void SpiralMatrix()
        {
            int end = n;
            int start = 0;
            int counter = 1;

            do
            {
                for (int i = start; i < end; i++)
                {
                    matrix[i, start] = counter;
                    counter++;
                }

                for (int j = start + 1; j < end; j++)
                {
                    matrix[end - 1, j] = counter;
                    counter++;
                }

                for (int k = end - 2; k >= start; k--)
                {
                    matrix[k, end - 1] = counter;
                    counter++;
                }

                for (int m = end - 2; m >= start + 1; m--)
                {
                    matrix[start, m] = counter;
                    counter++;
                }

                start++;
                end--;
            }
            while (end - start > 0);

            PrintMatrix();
        }

        private static void MatrixDiagonallyAssigned()
        {
            int counter = 0;

            for (int row = 0; row <= matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    counter++;
                    matrix[(n - 1) - (row - col), col] = counter;
                }
            }

            for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
            {
                for (int col = row; col >= 0; col--)
                {
                    counter++;
                    matrix[row - col, n - 1 - col] = counter;
                }
            }

            PrintMatrix();
        }

        private static void MatrixIncreasingAndDecreasingColumns()
        {
            int counter = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((col & 1) == 0)
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        counter++;
                        matrix[row, col] = counter;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                    {
                        counter++;
                        matrix[row, col] = counter;
                    }
                }
            }

            PrintMatrix();
        }

        private static void MatrixIncreasingColumns()
        {
            int counter = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    counter++;
                    matrix[row, col] = counter;
                }
            }

            PrintMatrix();
        }

        private static void PrintMatrix()
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