// 4. Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
// and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

namespace LargestNumberInArray
{
    using System;
    using System.Linq;

    class LargestNumberInArray
    {
        private static void Main()
        {
            // enter random values in the array
            Random rndGen = new Random();

            int arrSize = rndGen.Next(5, 15);
            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = rndGen.Next(0, 50);
            }

            // print the unsorted array on the console
            Console.WriteLine("Unsorted array: {0}", string.Join(",", arr));

            // sort the array
            Array.Sort(arr);

            // print the sorted array on the console
            Console.WriteLine("Sorted array: {0}", string.Join(",", arr));

            // enter value for k
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            bool foundAnswer = false;
            int answer = 0;

            // find the largest number <=K in the array
            for (int i = k; i >= arr[0]; i--)
            {
                int index = Array.BinarySearch(arr, i);

                if (index >= 0)
                {
                    answer = arr[index];
                    foundAnswer = true;
                    break;
                }
            }

            // print the result
            if (foundAnswer)
            {
                Console.WriteLine("The largest number that is <=K({0}) is {1}", k, answer);
            }
            else
            {
                Console.WriteLine("There isn't a number <=K({0}) in the array", k);
            }
        }
    }
}