namespace ClassMatrix
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Matrix
    {
        public static Random Rnd = new Random();
        private readonly int[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Columns
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        // define an indexer
        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        // override the ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Columns; col++)
                {
                    result.Append(this.matrix[row, col].ToString().PadLeft(5));
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }

        // override the + operator for adding
        public static Matrix operator +(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, first.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = first[row, col] + second[row, col];
                }
            }

            return result;
        }

        // override the - operator for substraction
        public static Matrix operator -(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, first.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = first[row, col] - second[row, col];
                }
            }

            return result;
        }

        // override the * operator for multiplication
        public static Matrix operator *(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, first.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = first[row, col] * second[row, col];
                }
            }

            return result;
        }
    }
}