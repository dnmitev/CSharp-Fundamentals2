// 3. Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

namespace BrackectsCorrectlyPut
{
    using System;
    using System.Linq;

    public class BrackectsCorrectlyPut
    {
        private static void Main()
        {
            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();

            bool areCorrect = AreBracketsPutCorrectly(input);

            if (areCorrect)
            {
                Console.WriteLine("Brackets are correct.");
            }
            else
            {
                Console.WriteLine("Brackets position isn't correct");
            }
        }

        private static bool AreBracketsPutCorrectly(string input)
        {
            int brackets = 0;
            bool correctly = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    brackets++;
                }
                else if (input[i] == ')')
                {
                    brackets--;
                }

                if (brackets < 0)
                {
                    break;
                }
            }

            if (brackets == 0)
            {
                correctly = true;
            }

            return correctly;
        }
    }
}