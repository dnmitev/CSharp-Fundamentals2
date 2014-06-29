// 6. Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with '*'.
// Print the result string into the console

namespace CharactersAndAsterisks
{
    using System;
    using System.Linq;
    using System.Text;

    public class CharactersAndAsterisks
    {
        private static void Main()
        {
            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            if (input.Length < 20)
            {
                result.Append(input);

                int counter = 0;

                while ((20 - input.Length - counter) > 0)
                {
                    result.Append("*");
                    counter++;
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}