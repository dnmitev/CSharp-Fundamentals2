// 20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
// Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

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
            arr = new int[n];

            // call the method to find the Variations with value of 0
            FindVariation(0);
        }

        static void FindVariation(int currentVariation)
        {
            // bottom of recursion
            if (currentVariation == n)
            {
                PrintVariations();
                return;
            }

            // recursivly call back the FindVariation method and writing values to the array
            for (int count = 1; count <= k; count++)
            {
                arr[currentVariation] = count;
                FindVariation(currentVariation + 1);
            }
        }

        static void PrintVariations()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }
    }
}