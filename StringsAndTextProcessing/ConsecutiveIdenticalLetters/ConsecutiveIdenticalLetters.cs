//23. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 

namespace ConsecutiveIdenticalLetters
{
    using System;
    using System.Text;

    public class ConsecutiveIdenticalLetters
    {
        static void Main()
        {
            int count = 0;
            string input = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i+=count)
            {
                count = 1;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] != input[j])
                    {
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }

                output.Append(input[i]);
            }

            Console.WriteLine(output.ToString());
        }
    }
}
