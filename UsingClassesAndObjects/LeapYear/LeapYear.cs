// 1. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

namespace LeapYear
{
    using System;
    using System.Linq;

    internal class LeapYear
    {
        private static void Main()
        {
            // enter year as a number on the console
            Console.Write("Please enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // declare a flag to store the boolean value of the statement is the year leap
            bool isLeap = DateTime.IsLeapYear(year);

            // print an adequate massage on the console, saying is the year leap
            if (isLeap)
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is NOT a leap year.", year);
            }
        }
    }
}