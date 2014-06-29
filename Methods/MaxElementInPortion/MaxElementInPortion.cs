// 9. Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

namespace MaxElementInPortion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MaxElementInPortion
    {
        private static readonly Random rndGen = new Random();

        static void Main()
        {
            int[] arr = InputRandomArray();
            PrintArray(arr);
            int startPosition;

            // enter start index for the portion and check whether it isn't out of range
            do
            {
                Console.Write("Please enter a start index for the array portion: ");
                startPosition = int.Parse(Console.ReadLine());
            } while (startPosition >= arr.Length);

            // find the max elelement in the portion
            int maxElement = 0;
            maxElement = FindMaxInPortion(startPosition, arr);

            Console.WriteLine("The max element in the current portion is: {0}", maxElement);

            // ascending sort
            AscendingSort(arr);
            Console.Write("Ascending sort: ");
            PrintArray(arr);

            // descending sort
            DescendigSort(arr);
            Console.Write("Descending sort: ");
            PrintArray(arr);
        }

        private static void DescendigSort(int[] arr)
        {
            // using selection sort algotithm
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        private static void AscendingSort(int[] arr)
        {
            // using selection sort algotithm
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        private static int FindMaxInPortion(int startPosition, int[] arr)
        {
            int maxElement = int.MinValue;

            for (int i = startPosition; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }

            return maxElement;
        }

        private static int[] InputRandomArray()
        {
            int[] intArray = new int[rndGen.Next(3, 30)];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rndGen.Next(0, 100);
            }

            return intArray;
        }

        private static void PrintArray(int[] intArray)
        {
            Console.WriteLine(string.Join(",", intArray));
        }
    }
}
