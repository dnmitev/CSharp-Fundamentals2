namespace Patterns
{
    using System;

    class Patterns
    {
        static int[,] matrix;
        static bool patternFound = false;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];

            ReadInputData();
            CheckForPatterns();
        }

        private static void CheckForPatterns()
        {
            int bestSum = int.MinValue;
            bool patternCondition = false;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int currSum = 0;

                for (int col = 0; col < matrix.GetLength(1) - 4; col++)
                {
                    patternCondition =
                                      matrix[row, col] == matrix[row, col + 1] - 1 &&
                                      matrix[row, col + 1] == matrix[row, col + 2] - 1 &&
                                      matrix[row, col + 2] == matrix[row + 1, col + 2] - 1 &&
                                      matrix[row + 1, col + 2] == matrix[row + 2, col + 2] - 1 &&
                                      matrix[row + 2, col + 2] == matrix[row + 2, col + 3] - 1 &&
                                      matrix[row + 2, col + 3] == matrix[row + 2, col + 4] - 1;

                    if (patternCondition)
                    {
                        patternFound = true;
                        currSum =
                                 matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                 matrix[row + 1, col + 2] + matrix[row + 2, col + 2] +
                                 matrix[row + 2, col + 3] + matrix[row + 2, col + 4];

                        if (currSum > bestSum)
                        {
                            bestSum = currSum;
                        }
                    }
                }
            }

            if (patternFound)
            {
                Console.WriteLine("YES {0}", bestSum);
            }
            else
            {
                int otherSum = GetMainDiagonalSum();
                Console.WriteLine("NO {0}", otherSum);
            }
        }

        private static int GetMainDiagonalSum()
        {
            int result = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result += matrix[i, i];
            }

            return result;
        }

        private static void ReadInputData()
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int cols = 0; cols < line.Length; cols++)
                {
                    matrix[rows, cols] = int.Parse(line[cols]);
                }
            }
        }
    }
}