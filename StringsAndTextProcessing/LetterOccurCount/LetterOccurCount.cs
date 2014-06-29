// 21. Write a program that reads a string from the console and prints all different letters 
// in the string along with information how many times each letter is found. 

namespace LetterOccurCount
{
    using System;

    public class LetterOccurCount
    {
        static void Main()
        {
            string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. ";

            int[] occuranceCount = new int['z' - 'a' + 1];

            foreach (char letter in text.ToLower())
            {
                if ('a' <= letter && 'z' >= letter)
                {
                    occuranceCount[letter - 'a']++;
                }
            }

            for (int i = 0; i < occuranceCount.Length; i++)
            {
                if (occuranceCount[i] != 0)
                {
                    Console.WriteLine("{0}: {1} times", (char)(i + 'a'), occuranceCount[i]);
                }
            }
        }
    }
}
