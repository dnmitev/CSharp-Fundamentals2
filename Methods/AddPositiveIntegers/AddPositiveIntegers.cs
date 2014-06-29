// 8. Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
// Each of the numbers that will be added could have up to 10 000 digits.

namespace AddPositiveIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class AddPositiveIntegers
    {
        private static readonly Random rndGen = new Random();

        private static void Main()
        {
            // randomly generate first number
            int[] firstNumber = InputRandomArray();
            Console.Write("First number: ");
            PrintArray(firstNumber);

            // randomly generate second number
            int[] secondNumber = InputRandomArray();
            Console.Write("Second number: ");
            PrintArray(secondNumber);

            // print the result on the console
            Console.WriteLine(string.Join("", Adding(firstNumber, secondNumber)));
        }

        private static List<int> Adding(int[] firstNumber, int[] secondNumber)
        {
            // declare a list to store the resulting adds
            List<int> result = new List<int>();

            // declare the limits
            int minLength = Math.Min(firstNumber.Length, secondNumber.Length);
            int maxLength = Math.Max(firstNumber.Length, secondNumber.Length);
            int add = 0;

            // declare flags to determine which array is longer
            bool minFirstLength = false;
            bool minSecondLength = false;

            // check whether array 1 or 2 is longer
            if (firstNumber.Length > secondNumber.Length)
            {
                minSecondLength = true;
            }
            else
            {
                minFirstLength = true;
            }

            // go through the sequences with equal length and add their digits
            for (int i = 0; i < minLength; i++)
            {
                result.Add((firstNumber[i] + secondNumber[i] + add) % 10);
                add = (firstNumber[i] + secondNumber[i]) / 10;
            }

            // go throough the other digits
            if (minFirstLength)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    result.Add((0 + secondNumber[i] + add) % 10);
                    add = (0 + secondNumber[i]) / 10;
                }
            }
            else if (minSecondLength)
            {
                for (int i = 0; i < minLength; i++)
                {
                    result.Add((firstNumber[i] + 0 + add) % 10);
                    add = (firstNumber[i] + 0) / 10;
                }
            }

            // reverse the added digits to form the number
            result.Reverse();

            // return the rusult
            return result;
        }

        private static int[] InputRandomArray()
        {
            int[] intArray = new int[rndGen.Next(3, 30)];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rndGen.Next(0, 10);
            }

            return intArray;
        }

        private static void PrintArray(int[] intArray)
        {
            Console.WriteLine(string.Join("", intArray));
        }
    }
}