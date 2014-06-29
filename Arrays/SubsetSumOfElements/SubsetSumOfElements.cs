// 16.  We are given an array of integers and a number S. 
// Write a program to find if there exists a subset of the elements of the array that has a sum S. 
// Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

// help used: http://www.youtube.com/watch?v=Sk0PX0YSHtk#t=3979

namespace SubsetSumOfElements
{
    using System;

    class SubsetSumOfElements
    {
        static void Main()
        {
            // enter the velues of the array
            Random randomGenerator = new Random();
            int arrSize = randomGenerator.Next(5, 10);

            int[] arr = new int[arrSize];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomGenerator.Next(0, 20);
            }

            // print the array on the console
            Console.WriteLine("The array is: {0}", string.Join(",", arr));

            // enter value for the sum we are looking for
            Console.Write("S = ");
            int s = int.Parse(Console.ReadLine());

            // the max count of combos is exactly 2^arrLength - 1;
            int maxCombinations = (int)Math.Pow(2, arr.Length) - 1;

            bool sumExists = false;

            for (int i = 1; i < maxCombinations; i++)
            {
                int currentSum = 0;

                for (int j = 1; j < arr.Length; j++)
                {
                    // every number is up to all numbers in the array
                    if (((i >> (j - 1)) & 1) == 1)
                    {
                        currentSum += arr[j - 1];
                    }

                    // check if the sum is reached
                    if (currentSum == s)
                    {
                        sumExists = true;
                    }
                }
            }

            if (sumExists)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
