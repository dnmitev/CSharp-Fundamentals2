// 4. Write a method that counts how many times given number appears in given array. 
// Write a test program to check if the method is working correctly.

namespace CountAppearings
{
    using System;
    using System.Linq;

    internal class CountAppearings
    {
        private static readonly Random rndGen = new Random();

        // define the variables needed in all methods
        private static int arrSize;
        private static int[] intArray;

        private static void Main()
        {
            // declare and assign the array size and the array
            arrSize = rndGen.Next(10, 20);
            intArray = new int[arrSize];

            // input the array
            InputRandomArray();

            // print the array
            PrintArray(intArray);

            // find the max count
            MaxCountOfAppearings(intArray);
        }

        private static void InputRandomArray()
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rndGen.Next(1, 5);
            }
        }

        private static void PrintArray(int[] intArray)
        {
            Console.WriteLine("The array is: {0}", string.Join(",", intArray));
        }

        private static void MaxCountOfAppearings(int[] intArray)
        {
            int bestCount = 0;
            int currentCount = 0;

            int bestMember = 0;
            int currentMember = 0;

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        currentCount++;
                        currentMember = intArray[i];
                    }
                }

                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestMember = currentMember;
                }

                currentCount = 0;
                currentMember = 0;
            }

            Console.WriteLine("{0} appeared {1} times in the array", bestMember, bestCount);
        }
    }
}