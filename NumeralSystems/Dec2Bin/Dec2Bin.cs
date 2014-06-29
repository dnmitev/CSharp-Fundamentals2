// 1. Write a program to convert decimal numbers to their binary representation.

namespace Dec2Bin
{
    using System;
    using System.Linq;

    internal class Dec2Bin
    {
        private static void Main()
        {
            Console.Write("Please enter a decimal number: ");
            int number = int.Parse(Console.ReadLine());

            string result = ConvertToBinary(number);
            Console.WriteLine("The binary expression of {0} is {1}", number, result);
        }

        private static string ConvertToBinary(int number)
        {
            string binary = string.Empty;

            while (number != 0)
            {
                binary = string.Format("{0}{1}", number % 2, binary);
                number /= 2;
            }

            return binary;
        }
    }
}