// 13. Write a program that reverses the words in given sentence.

// http://gskinner.com/RegExr/

namespace WordsInSentenceReversing
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class WordsInSentenceReversing
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            string pattern = @"\s+|\,\s*|\;\s*|\:\s*|\-\s*|\!\s*|\?\s*|\.\s*";

            Stack<string> words = new Stack<string>();
            Queue<string> separators = new Queue<string>();

            foreach (string word in Regex.Split(sentence, pattern))
            {
                if (word != string.Empty)
                {
                    words.Push(word);
                }
            }

            foreach (Match separator in Regex.Matches(sentence, pattern))
            {
                separators.Enqueue(separator.Value);
            }

            StringBuilder reversed = new StringBuilder();

            while (words.Count > 0 && separators.Count > 0)
            {
                reversed.Append(words.Pop());
                reversed.Append(separators.Dequeue());
            }

            Console.WriteLine(reversed.ToString());
        }
    }
}
