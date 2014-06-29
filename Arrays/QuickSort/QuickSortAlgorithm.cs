// 14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).


// Help used: http://www.youtube.com/watch?feature=player_detailpage&v=fGmj56k78m4#t=6028
//     also: http://pages.stern.nyu.edu/~panos/java/Quicksort/index.html

using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    class QuickSortAlgorithm
    {
        private static List<string> QuickSort(List<string> listOfStrings) // method to quick sort the lists
        {
            // if a list consists of a single value it is sorted
            if (listOfStrings.Count <= 1)
            {
                return listOfStrings;
            }

            // Pivot choice, the middle element
            string pivot = listOfStrings[listOfStrings.Count / 2];

            // define new list in order to store the less and the bigger values than the pivot
            List<string> less = new List<string>();
            List<string> greater = new List<string>();

            // go through the list and check values to the pivot
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                if (i != (listOfStrings.Count / 2))
                {
                    if (string.Compare(listOfStrings[i], pivot) < 0)
                    {
                        less.Add(listOfStrings[i]);
                    }
                    else
                    {
                        greater.Add(listOfStrings[i]);
                    }
                }
            }

            // return recursivly using the "QuickSort" through the greater and the less lists
            return ConcatenateLists(QuickSort(less), pivot, QuickSort(greater));
        }

        private static List<string> ConcatenateLists(List<string> less, string pivot, List<string> greater) 
        {
            List<string> result = new List<string>();

            for (int i = 0; i < less.Count; i++)
            {
                result.Add(less[i]);
            }

            result.Add(pivot);

            for (int i = 0; i < greater.Count; i++)
            {
                result.Add(greater[i]);
            }

            return result;
        }

        private static void Main()
        {
            //generate random array size with random elements
            Random randomGenerator = new Random();
            List<string> stringList = new List<string>();

            for (int i = 0; i < randomGenerator.Next(10, 26); i++)
            {
                stringList.Add(((char)randomGenerator.Next(65, 90)).ToString());
            }

            // print the unsorted array
            Console.WriteLine("Unsorted array: {0}", String.Join(" ", stringList));

            // print the sorted array
            Console.WriteLine("Sorted array: {0}", String.Join(" ", QuickSort(stringList)));
        }
    }
}