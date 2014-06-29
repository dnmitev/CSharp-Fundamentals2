// 5. Write a program that finds the maximal increasing sequence in an array. 

// Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

namespace MaximalIncreasingSequence
{
    using System;

    class MaximalIncreasingSequence
    {
        static void Main()
        {
            // enter the size of the array from the console
            Console.Write("Please enter size of arrays:");
            int size = int.Parse(Console.ReadLine());

            // initializing the array
            int[] genArray = new int[size];

            // enter elements' values
            for (int index = 0; index < size; index++)
            {
                genArray[index] = int.Parse(Console.ReadLine());
            }

            // print on the console the elements of the array
            for (int index = 0; index < size; index++)
            {
                Console.Write("{0} ", genArray[index]);
            }
            Console.WriteLine();

            // finding the sequence
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;

            for (int i = 0; i < genArray.Length - 1; i++)
            {
                int j = i;
                start = j;
                len = 1;

                while (j < (size - 1) && genArray[j] < genArray[j + 1])
                {
                    j++;
                    len++;
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }

            Console.Write("{ ");
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(genArray[i] + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
