// 9.Write a program that finds the most frequent number in an array. 
// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
namespace MostFrequentNumber
{
    using System;

    class MostFrequentNumber
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

            // find the most frequent number in the array
            int number = arr[0];
            int maxCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentCount = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    number = arr[i];
                }
            }

            Console.WriteLine("The most frequent number is: {0}, because it shows up {1} in the array", number, maxCount);
        }
    }
}
