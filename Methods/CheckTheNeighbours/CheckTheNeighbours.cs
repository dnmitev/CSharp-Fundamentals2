// 5. Write a method that checks if the element at given position in given array of integers is bigger than 
// its two neighbors (when such exist).

namespace CheckTheNeighbours
{
    using System;
    using System.Linq;

    internal class CheckTheNeighbours
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

            // input the position to be checked
            int position;

            do
            {
                Console.Write("Please enter the position to be checked: ");
                position = int.Parse(Console.ReadLine());
            }
            while (position <= 0 || position >= intArray.Length - 1);

            NeighbourComparison(position, intArray);
        }

        private static void NeighbourComparison(int position, int[] intArray)
        {
            bool isBigger = false;

            if (intArray[position] > intArray[position - 1] && intArray[position] > intArray[position + 1])
            {
                isBigger = true;
            }

            if (isBigger)
            {
                Console.WriteLine("The element at position {0} ({1}) is bigger than its neighbours({2},{3})",
                    position, intArray[position], intArray[position - 1], intArray[position + 1]);
            }
            else
            {
                Console.WriteLine("The element at position {0} ({1}) is NOT bigger than its neighbours({2},{3})",
                    position, intArray[position], intArray[position - 1], intArray[position + 1]);
            }
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