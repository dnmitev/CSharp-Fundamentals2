// 13.Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).


// I used this help: http://www.youtube.com/watch?v=fGmj56k78m4#t=3980
//        and this: http://en.wikipedia.org/wiki/Merge_sort

using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    internal class MergeSortAlgorithm
    {
        public static List<int> MergeSort(List<int> numbers) // method to merge sort each list
        {
            // when a list of a single value is reached, its considered sorted
            if (numbers.Count <= 1)
            {
                return numbers;
            }

            // find the middle of the total count of numbers 
            int middle = numbers.Count / 2;

            // generate new list in order to store the values of the non-merged arrays
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            // store values in the left list 
            for (int i = 0; i < middle; i++)
            {
                left.Add(numbers[i]);
            }

            //store values in the right list
            for (int i = middle; i < numbers.Count; i++)
            {
                right.Add(numbers[i]);
            }

            // recursivly call the "MergeSort" method until the numbers' count has reached 1
            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private static void AppendListWhileMerge(List<int> merging, List<int> merged) //method to append lists after merging
        {
            merged.Add(merging[0]);
            merging.RemoveAt(0);
        }

        private static List<int> Merge(List<int> left, List<int> right) // method to merge the current list
        {
            // generate new list to store the merged lists
            List<int> merged = new List<int>();

            // compare the values of the list and merge them into a single list called merged
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        AppendListWhileMerge(left, merged);
                    }
                    else
                    {
                        AppendListWhileMerge(right, merged);
                    }
                }
                else if (left.Count > 0)
                {
                    AppendListWhileMerge(left, merged);
                }
                else if (right.Count > 0)
                {
                    AppendListWhileMerge(right, merged);
                }
            }

            return merged;
        }

        private static void Main()
        {
            // generate random array size with random elements
            Random randomGenerator = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < randomGenerator.Next(10, 20); i++)
            {
                numbers.Add(randomGenerator.Next(-200, 200));
            }

            // print the unsorted array
            Console.WriteLine("Unsorted array: {0}", String.Join(" ", numbers));

            // print the sorted array
            Console.WriteLine("Sorted array: {0}", String.Join(" ", MergeSort(numbers)));
        }
    }
}