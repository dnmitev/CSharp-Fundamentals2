// 5. Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 
// with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
// Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file.

namespace MatrixFromFile
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class MatrixFromFile
    {
        public static int GetMaxSum(int[,] matrix)
        {
            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int sum = 0;

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (bestSum < sum)
                    {
                        bestSum = sum;
                    }
                }
            }

            return bestSum;
        }

        private static void Main()
        {
            // get the encoding
            Encoding encoding = Encoding.UTF8;

            try
            {
                // initialize a new StreamReader
                StreamReader reader = new StreamReader(@"..\..\sample.txt", encoding);

                // get the matrix in ints
                int[,] matrix = ReadMatrix(reader);

                // find the platform 2x2 with max sum
                int result = GetMaxSum(matrix);

                // print it in a file
                StreamWriter output = new StreamWriter(@"..\..\outputFile.txt", false, encoding);
                PrintResultToFile(output, result);

                // print adequate massage on the console
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Output file successfully generated. Check \\TextFiles\\MatrixFromFile");
            }
            catch (FileNotFoundException exc)
            {
                Console.Error.WriteLine("Cannot find '{0}' file.", exc.FileName);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot open file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.Error.WriteLine("There is no access to write files.");
            }
        }

        private static void PrintResultToFile(StreamWriter output, int result)
        {
            using (output)
            {
                output.WriteLine(result);
            }
        }

        private static int[,] ReadMatrix(StreamReader reader)
        {
            using (reader)
            {
                int size = int.Parse(reader.ReadLine());
                int[,] matrix = new int[size, size];

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    string[] numbers = reader.ReadLine().Split(' ');

                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[rows, cols] = int.Parse(numbers[cols]);
                    }
                }

                return matrix;
            }
        }
    }
}