// 17. Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
// Find in the array a subset of K elements that have sum S or indicate about its absence.

namespace SubsetSumOfAmountOfElements
{
    using System;
    using System.Collections.Generic;

    class SubsetSumOfAmountOfElements
    {
        static void Main()
        {
            // enter the velues of the array
            Random randomGenerator = new Random();
            int arrSize = randomGenerator.Next(5, 10);

            int[] arr = new int[arrSize];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomGenerator.Next(0, 20);
            }

            // print the array on the console
            Console.WriteLine("The array is: {0}", string.Join(",", arr));

            // enter value for the sum we are looking for
            Console.Write("S = ");
            int s = int.Parse(Console.ReadLine());

            // enter value for the count of elements we are looking for
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            // the max count of combos is exactly 2^arrLength - 1;
            int maxCombinations = (int)Math.Pow(2, arr.Length) - 1;
            int counter = 0;

            bool sumExists = false;

            List<int> subsetSumElements = new List<int>();

            for (int i = 1; i < maxCombinations; i++)
            {
                int currentSum = 0;

                for (int j = 1; j < arr.Length; j++)
                {
                    // every number is up to all numbers in the array
                    if (((i >> (j - 1)) & 1) == 1)
                    {
                        currentSum += arr[j - 1];
                        counter++;
                        subsetSumElements.Add(arr[j - 1]);
                    }
                }

                // check if the sum is reached with K elements
                if (currentSum == s && counter == k)
                {
                    sumExists = true;
                    break;
                }
                else
                {
                    counter = 0;
                    subsetSumElements.Clear();
                }
            }

            if (sumExists)
            {
                Console.WriteLine("The subset with sum of {0} is: {1}", s, string.Join(",", subsetSumElements));
            }
            else
            {
                Console.WriteLine("There is not such subset existing in the current array!");
            }
        }
    }
}
