// 6. Write a method that returns the index of the first element in array that is bigger than its neighbors, 
// or -1, if there’s no such element.

namespace BiggerThanItsNeighbours
{
    using System;
    using System.Linq;

    internal class BiggerThanItsNeighbours
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

            // find the index of the first element bigger than its neighbours
            int foundIndex = NeighbourComparison(intArray);

            if (foundIndex != -1)
            {
                Console.WriteLine("The index of the 1st element bigger than its neighbours is: {0}", foundIndex);
            }
            else
            {
                Console.WriteLine(foundIndex);
            }
        }

        private static int NeighbourComparison(int[] intArray)
        {
            int index = 0;

            for (int i = 1; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > intArray[i - 1] && intArray[i] > intArray[i + 1])
                {
                    index = i;
                    return index;
                }
            }

            return -1;
        }

        private static void InputRandomArray()
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rndGen.Next(-50, 50);
            }
        }

        private static void PrintArray(int[] intArray)
        {
            Console.WriteLine("The array is: {0}", string.Join(",", intArray));
        }
    }
}