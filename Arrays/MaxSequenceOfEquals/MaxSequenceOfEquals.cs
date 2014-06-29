// 4.Write a program that finds the maximal sequence of equal elements in an array.

// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

namespace MaxSequenceOfEquals
{
    using System;

    class MaxSequenceOfEquals
    {
        static void Main()
        {
            // enter the size of the array from the console
            Console.Write("Please enter size of arrays:");
            int size = int.Parse(Console.ReadLine());

            // initializing the array
            int[] generalArray = new int[size];

            // enter elements' values
            for (int index = 0; index < size; index++)
            {
                generalArray[index] = int.Parse(Console.ReadLine());
            }

            // print on the console the elements of the array
            for (int index = 0; index < size; index++)
            {
                Console.Write("{0} ", generalArray[index]);
            }
            Console.WriteLine();

            // finding the sequence
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;

            for (int i = 0; i < generalArray.Length - 1; i++)
            {
                int j = i;
                start = generalArray[j];
                len = 1;

                while (j < (size - 1) && generalArray[j] == generalArray[j + 1])
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
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestStart+" ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
