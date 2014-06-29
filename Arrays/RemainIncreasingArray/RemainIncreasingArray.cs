// 18. Write a program that reads an array of integers and removes from it a minimal number of elements in such way 
// that the remaining array is sorted in increasing order. Print the remaining sorted array. 
// Example:	{6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}

namespace RemainIncreasingArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemainIncreasingArray
    {
        private static void Main()
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

            // the max count of combos is exactly 2^arrLength - 1;
            int maxCombinations = (int)Math.Pow(2, arr.Length) - 1;
            int minValue;
            int counter;
            int totalCount = 0;

            List<int> incrSorted = new List<int>();
            List<int> check = new List<int>();

            for (int i = 0; i < maxCombinations; i++)
            {
                counter = 0;
                minValue = int.MinValue;
                // chech all combos which has next element bigger or equal than the previous
                for (int j = 0; j < arr.Length; j++)
                {
                    // every number is up to all numbers in the array
                    if (((i >> j) & 1) == 1 && minValue <= arr[j])
                    {
                        minValue = arr[j];
                        check.Add(arr[j]);
                        counter++;
                    }
                }

                // check if the count of the elements is bigger than that reached in the prev combo
                if (counter > totalCount)
                {
                    incrSorted.Clear();
                    totalCount = counter;

                    for (int k = 0; k < check.Count; k++)
                    {
                        incrSorted.Add(check[k]);
                    }
                }

                check.Clear();
            }

            Console.WriteLine("After removing elements the array in increasing order is: {0}", string.Join(",", incrSorted));
        }
    }
}