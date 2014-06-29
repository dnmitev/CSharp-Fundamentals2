// 19. Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
// Example: n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

namespace PermutationsOfNumbers
{
    using System;
    using System.Linq;

    internal class PermutationsOfNumbers
    {
        private static void Main()
        {
            // enter a value for N
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            bool[] isUsed = new bool[n];

            Permutation(vector, n, isUsed, 0);
        }

        private static void Permutation(int[] vector, int n, bool[] isUsed, int index)
        {
            // the are not more numbers to permute
            if (index == n)
            {
                Print(vector);
            }

            // go through all the numbers 1....N
            for (int i = 0; i < n; i++)
            {
                // count the number as used
                if (!isUsed[i])
                {
                    isUsed[i] = true;
                    vector[index] = i + 1;

                    // call back tha function for the next number
                    Permutation(vector, n, isUsed, index + 1);

                    // set the current number as not used
                    isUsed[i] = false;
                }
            }
        }

        private static void Print(int[] vector)
        {
            Console.WriteLine("{0}", string.Join(",", vector));
        }
    }
}