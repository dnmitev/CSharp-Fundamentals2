// 11. Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 

namespace BinarySearch
{
    using System;

    class BinarySearch
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

            // sorting by the selection algorithm
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

            // print the SORTED array on the console
            Console.WriteLine("After using the selection algorith:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

            // binary search through the sorted array to find the index
            Console.Write("Enter the element which index you are looking for: ");
            int targetNumber = int.Parse(Console.ReadLine());

            int first = 0;
            int last = arr.Length - 1;
            int middle = 0;

            bool found = false;

            while (!found && first <= last)
            {
                middle = (first + last) / 2;

                if (targetNumber < arr[middle])
                {
                    last = middle - 1;
                }
                else if (targetNumber > arr[middle])
                {
                    first = middle + 1;
                }
                else
                {
                    found = true;
                }
            }

            Console.WriteLine("{0} is found with index {1}", targetNumber, middle);
        }
    }
}
