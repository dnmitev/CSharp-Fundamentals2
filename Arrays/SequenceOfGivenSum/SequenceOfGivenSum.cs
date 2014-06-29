// 10. Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
namespace SequenceOfGivenSum
{
    using System;

    class SequenceOfGivenSum
    {
        static void Main()
        {

            // input the size of the array and the array on the console
            Console.Write("Enter the size of the array: ");
            int arrSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the sum: ");
            int givenSum = int.Parse(Console.ReadLine());

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

            // looking for a sequence that has the given sum
            int startIndex = 0;
            int currentSum = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                currentSum += arr[i];
                startIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    currentSum += arr[j];

                    if (currentSum == givenSum)
                    {
                        for (int k = startIndex; k <= j; k++)
                        {
                            Console.Write(arr[k] + " ");
                        }
                        Console.WriteLine();
                        return;
                    }
                }

                currentSum = 0;
            }

            Console.WriteLine("There isn't a sequence with sum {0} presented in the array", givenSum);
        }
    }
}
