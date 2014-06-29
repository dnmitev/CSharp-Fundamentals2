// 3. We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
// located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 

namespace LongestSequenceOfStrings
{
    using System;
    using System.Linq;

    class LongestSequenceOfStrings
    {
        private static void Main()
        {
            // hardcode the input matrix of strings
            string[,] matrixOfStrings = 
            {
                { "ha", "fifi", "ho", "fi" },
                { "fo", "ha", "hi", "xx" },
                { "xxx", "fo", "ha", "xx" }
            };

            // print the matrix on the console
            PrintMatrix(matrixOfStrings);

            int bestCount = 0;
            string bestString = " ";
            int rowCount = 0;
            int colCount = 0;
            int diagonalCount = 0;

            // go through the matrix and check its elements for coincidences
            for (int row = 0; row < (matrixOfStrings.GetLength(0) - 1); row++)
            {
                for (int col = 0; col < (matrixOfStrings.GetLength(1) - 1); col++)
                {
                    if (matrixOfStrings[row, col] == matrixOfStrings[row, col + 1])
                    {
                        rowCount++;

                        if (bestCount < rowCount)
                        {
                            bestCount = rowCount;
                            bestString = matrixOfStrings[row, col];
                        }
                    }

                    if (matrixOfStrings[row, col] == matrixOfStrings[row + 1, col])
                    {
                        colCount++;

                        if (bestCount < colCount)
                        {
                            bestCount = colCount;
                            bestString = matrixOfStrings[row, col];
                        }
                    }

                    if (matrixOfStrings[row, col] == matrixOfStrings[row + 1, col + 1])
                    {
                        diagonalCount++;

                        if (bestCount < diagonalCount)
                        {
                            bestCount = diagonalCount;
                            bestString = matrixOfStrings[row, col];
                        }
                    }
                }
            }

            // print which string is mosly found and how many times it's found
            Console.WriteLine("{0} is found {1} times!", bestString, bestCount);
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col].ToString().PadRight(5, ' '));
                }

                Console.WriteLine();
            }
        }
    }
}