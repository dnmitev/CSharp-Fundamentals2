// BGCoder: http://bgcoder.com/Contests/Practice/Index/54#4

namespace TwoIsBetterThanOne
{
    using System;
    using System.Collections.Generic;

    public class TwoIsBetterThanOne
    {
        private static void Main()
        {
            // first task
            string inputFirstTask = Console.ReadLine();

            long[] range = GetInputParsed(inputFirstTask);

            long A = range[0];
            long B = range[1];

            int resultOfFistTask = FindCountOfLuckyNumbers(A, B);

            // second task
            string inputSecondTask = Console.ReadLine();
            int percent = int.Parse(Console.ReadLine());

            long[] valueList = GetInputParsed(inputSecondTask);

            long resultOfSecondTask = FindSmallestElement(valueList, percent);

            // answers
            Console.WriteLine(resultOfFistTask);
            Console.WriteLine(resultOfSecondTask);
        }

        private static long FindSmallestElement(long[] valueList, int percent)
        {
            Array.Sort(valueList);

            for (int i = 0; i < valueList.Length; i++)
            {
                int smallerCount = 0;

                for (int j = 0; j < valueList.Length; j++)
                {
                    if (valueList[i] >= valueList[j])
                    {
                        smallerCount++;
                    }
                }

                if (smallerCount >= valueList.Length * (percent / 100.0))
                {
                    return valueList[i];
                }
            }

            return valueList[valueList.Length - 1];
        }

        private static int FindCountOfLuckyNumbers(long A, long B)
        {
            long max = (long)Math.Pow(10, 18);

            int left = 0;
            List<long> luckyNumbers = new List<long> { 3, 5 };

            while (left < luckyNumbers.Count)
            {
                int rigth = luckyNumbers.Count;

                for (int i = left; i < rigth; i++)
                {
                    if (luckyNumbers[i] <= max)
                    {
                        luckyNumbers.Add((luckyNumbers[i] * 10) + 3);
                        luckyNumbers.Add((luckyNumbers[i] * 10) + 5);
                    }
                }

                left = rigth;
            }

            int count = 0;

            foreach (var number in luckyNumbers)
            {
                if (number >= A && number <= B && IsPalindrome(number))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsPalindrome(long number)
        {
            long powOfTen = (long)Math.Pow(10, (long)Math.Log10(number));

            while (number > 0)
            {
                long right = number % 10;
                long left = number / powOfTen;

                if (left != 3 && left != 5)
                {
                    return false;
                }

                if (right != 3 && right != 5)
                {
                    return false;
                }

                if (left != right)
                {
                    return false;
                }

                number = number % powOfTen;
                number /= 10;
                powOfTen /= 100;
            }

            return true;
        }

        private static long[] GetInputParsed(string input)
        {
            string[] splitted = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            long[] result = new long[splitted.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = long.Parse(splitted[i]);
            }

            return result;
        }
    }
}