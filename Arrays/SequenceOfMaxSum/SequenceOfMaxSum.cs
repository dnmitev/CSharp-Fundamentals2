// 8. Write a program that finds the sequence of maximal sum in given array. 
// Example:	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
// Can you do it with only one loop (with single scan through the elements of the array)?

namespace SequenceOfMaxSum
{
    using System;

    class SequenceOfMaxSum
    {
        static void Main()
        {
            // input the size of the array and the array on the console
            Console.Write("Enter the size of the array: ");
            int arrSize = int.Parse(Console.ReadLine());

            int[] arr = new int[arrSize];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // print the array on the console
            Console.WriteLine("The array looks like:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

            // using the Kadane's algorith to find the sequence with max sum
            int maxSoFar = arr[0];
            int maxEndingHere = arr[0];

            int start = 0;
            int startTemp = 0;
            int end = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (maxEndingHere < 0)
                {
                    maxEndingHere = arr[i];
                    startTemp = i;
                }
                else
                {
                    maxEndingHere += arr[i];
                }

                if (maxEndingHere >= 0)
                {
                    maxSoFar = maxEndingHere;

                    start = startTemp;
                    end = i;
                }
            }
            // print the sequence on the console
            Console.WriteLine("The maximal sum is {0} and the subarray is:", maxSoFar);

            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
