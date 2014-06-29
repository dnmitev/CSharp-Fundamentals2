// 5. You are given an array of strings. Write a method that sorts the array by the length of its elements 
// (the number of characters composing them).

namespace SortStringsByLength
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class SortStringsByLength
    {
        private static void Main()
        {
            // enter the number of strings in the array
            Console.Write("Number of strings: ");
            int numberOfStrings = int.Parse(Console.ReadLine());

            // enter the strings in the array
            string[] stringArray = new string[numberOfStrings];

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            // print the array on the console
            Console.WriteLine("The array as entered is: {0}", string.Join(",", stringArray));

            // sort and print the array
            SortingByStringLengths(stringArray);
        }

        private static void SortingByStringLengths(string[] stringArray)
        {
            // declare a new list to store the string lenghts
            List<int> stringLenghts = new List<int>();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringLenghts.Add(stringArray[i].Length);
            }

            // sort the list of sting lenghts 
            stringLenghts.Sort();

            // exchange strings by their lenghts
            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = 0; j < stringArray.Length; j++)
                {
                    if (stringArray[j].Length == stringLenghts[i])
                    {
                        string tempString;
                        tempString = stringArray[i];
                        stringArray[i] = stringArray[j];
                        stringArray[j] = tempString;
                    }
                }
            }

            //print sorted array
            Console.WriteLine("Sorted by string lenghts: {0}", string.Join(",", stringArray));
        }
    }
}