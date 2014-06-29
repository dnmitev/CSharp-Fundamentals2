namespace ClassMatrix
{
    using System;
    using System.Linq;

    internal class MatrixUI
    {
        public static Random Rnd = new Random();

        public static void InputRandomMatrix(Matrix matrixInput)
        {
            for (int rows = 0; rows < matrixInput.Rows; rows++)
            {
                for (int cols = 0; cols < matrixInput.Columns; cols++)
                {
                    matrixInput[rows, cols] = Rnd.Next(1, 20);
                }
            }
        }

        private static void Main()
        {
            // declare random size of the matrix
            int rowsCount = Rnd.Next(3, 10);
            int colsCount = Rnd.Next(3, 10);

            // define and input random matrix as first matrix form class Matrix
            Matrix firstMatrix = new Matrix(rowsCount, colsCount);
            InputRandomMatrix(firstMatrix);
            Console.WriteLine("Matrix 1: ");
            Console.WriteLine(firstMatrix.ToString());

            // define and input random matrix as second matrix form class Matrix
            Matrix secondMatrix = new Matrix(rowsCount, colsCount);
            InputRandomMatrix(secondMatrix);
            Console.WriteLine("Matrix 2: ");
            Console.WriteLine(secondMatrix.ToString());

            // find the sum of the two matrices
            Matrix sum = firstMatrix + secondMatrix;
            Console.WriteLine("Matrix1 + Matrix 2: ");
            Console.WriteLine(sum.ToString());

            // find the substraction of the two matrices
            Matrix substraction = firstMatrix - secondMatrix;
            Console.WriteLine("Matrix1 - Matrix 2: ");
            Console.WriteLine(substraction.ToString());

            // find the product of the two matrices
            Matrix product = firstMatrix * secondMatrix;
            Console.WriteLine("Matrix1 * Matrix 2: ");
            Console.WriteLine(product.ToString());
        }
    }
}