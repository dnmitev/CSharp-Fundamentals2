namespace LargestArea
{
    using System;
    using System.Linq;

    internal class LargestArea
    {
        private static readonly Random Rnd = new Random();

        private static readonly int rowsCount = Rnd.Next(3, 10);
        private static readonly int colsCount = Rnd.Next(5, 10);

        private static readonly int[,] matrix = new int[rowsCount, colsCount];
        private static readonly bool[,] isVisited = new bool[rowsCount, colsCount];

        public static void InputRandomMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = Rnd.Next(1, 5);
                }
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols].ToString().PadLeft(3));
                }

                Console.WriteLine();
            }
        }

        private static void Main()
        {
            InputRandomMatrix(matrix);
            PrintMatrix(matrix);

            int bestCount = 0;
            int bestElem = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int currentCount = 0;

                    currentCount = GetCount(rows, cols, matrix[rows, cols]);

                    if (currentCount > bestCount)
                    {
                        bestElem = matrix[rows, cols];
                        bestCount = currentCount;
                    }
                }
            }

            Console.WriteLine("The largest area of equal neighbour elements is equal to {0} of {1}", bestCount, bestElem);
        }

        private static bool IsInRange(int row, int col)
        {
            bool inRange = true;

            // rows range check
            if ((row < 0) || (row >= rowsCount))
            {
                inRange = false;
            }

            // cols range check
            if ((col < 0) || (col >= colsCount))
            {
                inRange = false;
            }

            // check for been visited
            if (inRange)
            {
                if (isVisited[row, col])
                {
                    inRange = false;
                }
            }

            return inRange;
        }

        private static int GetCount(int row, int col, int value)
        {
            int count = 0;

            if (!IsInRange(row, col))
            {
                return count;
            }
            else
            {
                if (matrix[row, col] == value)
                {
                    count++;

                    isVisited[row, col] = true;

                    count += GetCount(row - 1, col - 1, value);
                    count += GetCount(row - 1, col, value);
                    count += GetCount(row - 1, col + 1, value);

                    count += GetCount(row, col - 1, value);
                    count += GetCount(row, col + 1, value);

                    count += GetCount(row + 1, col - 1, value);
                    count += GetCount(row + 1, col, value);
                    count += GetCount(row + 1, col + 1, value);
                }
            }

            return count;
        }
    }
}