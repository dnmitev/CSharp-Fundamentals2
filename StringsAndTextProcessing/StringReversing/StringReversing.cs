// 2. Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".


namespace StringReversing
{
    using System;
    using System.Linq;
    using System.Text;

    public class StringReversing
    {
        private static void Main()
        {
            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();

            string result = ReverseString(input);
            Console.WriteLine("The reversed string is: {0}", result);
        }

        private static string ReverseString(string input)
        {
            StringBuilder reversedString = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Append(input[i]);
            }

            return reversedString.ToString();
        }
    }
}