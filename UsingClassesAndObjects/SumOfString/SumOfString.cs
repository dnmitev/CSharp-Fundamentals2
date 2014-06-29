// 6. You are given a sequence of positive integer values written into a string, separated by spaces. 
// Write a function that reads these values from given string and calculates their sum. 
// Example: string = "43 68 9 23 318"  result = 461

namespace SumOfString
{
    using System;
    using System.Linq;

    internal class SumOfString
    {
        private static void Main()
        {
            Console.WriteLine("Please enter integers values divided by spaces:");
            string input = Console.ReadLine().Trim();

            CalculateSum(input);
        }

        private static void CalculateSum(string input)
        {
            int sum = 0;

            string[] stringNums = input.Split(' ');

            for (int i = 0; i < stringNums.Length; i++)
            {
                sum = sum + int.Parse(stringNums[i]);
            }

            Console.WriteLine("The sum is {0}", sum);
        }
    }
}