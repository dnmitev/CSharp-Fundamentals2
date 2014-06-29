// 22. Write a program that reads a string from the console and lists all different
// words in the string along with information how many times each word is found.

namespace WordsOccuranceCount
{
    using System;
    using System.Collections.Generic;

    public class WordsOccuranceCount
    {
        static void Main()
        {
            string text = "Some text to be used as text input, hardcoded in the program source code. Intentionally, some words in the text are repeated.";
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] = dictionary[word] + 1;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine("{0,-15} : {1} times", word.Key, word.Value);
            }
        }
    }
}
