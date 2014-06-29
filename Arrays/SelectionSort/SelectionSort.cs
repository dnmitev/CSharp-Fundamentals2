// 7.Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
// Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.

namespace SelectionSort
{
    using System;

    class SelectionSort
    {
        static void Main(string[] args)
        {
            // generate random array
            Random randomGenerator = new Random();
            int arrSize = randomGenerator.Next(10, 20);
            int[] arr = new int[arrSize];

            for (int i = 0; i < randomGenerator.Next(10, 20); i++)
            {
                arr[i] = randomGenerator.Next(0, 200);
            }

            // print the UNsorted array on the console
            Console.WriteLine("The array looks like:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

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
        }
    }
}
