//24. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace AlphabeticalOrder
{
    using System;

    public class AlphabeticalOrder
    {
        static void Main()
        {
            string text = "Sofia Plovdiv Burgas Varna Aitos Asenovgrad Velingrad Silistra Peshtera Karnobat Kasnakovo Belovo";
            string[] cities = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(cities);

            Console.WriteLine(string.Join(", ", cities));
        }
    }
}
