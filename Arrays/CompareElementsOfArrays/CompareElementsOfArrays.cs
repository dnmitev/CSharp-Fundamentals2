// 2.Write a program that reads two arrays from the console and compares them element by element.

namespace CompareElementsOfArrays
{
    using System;

    class CompareElementsOfArrays
    {
        static void Main()
        { 
            // enter the size of the arrays from the console
            Console.Write("Please enter size of arrays:");
            int size = int.Parse(Console.ReadLine());

            // initializing the two arrays
            int[] firstArray = new int[size];
            int[] secondArray = new int[size];

            // enter values for the arrays' elements
            for (int index = 0; index < size; index++)
            {
                Console.Write("firstArray[{0}] = ", index);
                firstArray[index] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < size; index++)
            {
                Console.Write("secondArray[{0}] = ", index);
                secondArray[index] = int.Parse(Console.ReadLine());
            }

            // comparing arrays by elements
            bool areEqual = true;

            for (int index = 0; index < size; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine("The two arrays have equal elements!");
            }
            else
            {
                Console.WriteLine("The two arrays doesn't have equal elements!");
            }
        }
    }
}
