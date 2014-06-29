// 21. Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
// Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;
using System.Linq;

namespace VariationsOfElements
{
    class VariationsOfElements
    {
        // make the variables visible in the whole class
        static int n;
        static int k;
        static int[] arr;

        private static void Main()
        {
            // input N and K values
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());

            // initialize an array with lenght n
            arr = new int[k];

            // call the method to find all combos with value of 0
            FindCombinations(arr, 0, 1);
        }

        private static void FindCombinations(int[] arr, int index, int currentNumber)
        {
            if (index == arr.Length) // if the Nth value is reached the array should be printed on the console
            {
                PrintArray();
            }
            else // otherwise +1 bigger value is stored in the array and the method is called back recursivly
            {
                for (int i = currentNumber; i <= n; i++)
                {
                    arr[index] = i;
                    FindCombinations(arr, index + 1, i + 1);
                }
            }

            // recursion bottom is reached when Nth value is reached
        }

        private static void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }
    }
}