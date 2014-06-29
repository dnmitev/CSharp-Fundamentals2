// 1.Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
// Print the obtained array on the console.

namespace InitializedByIndex
{
    using System;

    class InitializedByIndex
    {
        static void Main()
        {
            int[] arrayOfInts = new int[20];

            // initialize the array elements by its index multiplied by 5
            for (int index = 0; index < arrayOfInts.Length; index++)
            {
                arrayOfInts[index] = index * 5;
            }

            // print on the console the elements of the array
            for (int index = 0; index < arrayOfInts.Length; index++)
            {
                Console.Write("{0} ", arrayOfInts[index]);
            }
            Console.WriteLine();
        }
    }
}
