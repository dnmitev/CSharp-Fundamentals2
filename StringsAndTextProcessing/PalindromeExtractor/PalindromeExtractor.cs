// 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace PalindromeExtractor
{
    using System;

    public class PalindromeExtractor
    {
        static void Main()
        {
            string text = "Write a program that extracts from a given text all palindromes, e.g. ABBA lamal exe ";

            // split the string by spaces
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (IsPalindrome(words[i]) && words[i].Length > 1)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
