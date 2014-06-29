// BGCoder: http://bgcoder.com/Contests/Practice/Index/52#1

namespace GreedyDwarf
{
    using System;
    using System.Linq;

    public class GreedyDwarf
    {
        private static void Main()
        {
            // get the input
            string input = Console.ReadLine();

            int M = int.Parse(Console.ReadLine());

            int[] valley = GetInputParsed(input);

            int[][] patterns = new int[M][];

            for (int i = 0; i < M; i++)
            {
                string patternInput = Console.ReadLine();
                patterns[i] = GetInputParsed(patternInput);
            }

            // get the result
            int result = FindMaxCoinsCollected(valley, patterns);

            // print the result
            Console.WriteLine(result);
        }

        private static int FindMaxCoinsCollected(int[] valley, int[][] patterns)
        {
            int bestSum = int.MinValue;

            for (int i = 0; i < patterns.GetLength(0); i++)
            {
                int currentSum = GetCurrentSum(valley, patterns[i]);

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }
            }

            return bestSum;
        }

        private static int GetCurrentSum(int[] valley, int[] pattern)
        {
            bool[] visited = new bool[valley.Length];
            int index = 0;

            int coinSum = 0;

            for (int i = 0; i < valley.Length; i++)
            {
                if (visited[index])
                {
                    break;
                }

                visited[index] = true;
                coinSum += valley[index];
                index += pattern[i % pattern.Length];

                if (index < 0 || index >= valley.Length)
                {
                    break;
                }
            }

            return coinSum;
        }

        private static int[] GetInputParsed(string input)
        {
            string[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }

            return result;
        }
    }
}