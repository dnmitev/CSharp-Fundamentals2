// BG coder: http://bgcoder.com/Contests/Practice/Index/95#1
namespace MovingLetters
{
    using System;
    using System.Text;

    class MovingLetters
    {
        static StringBuilder ExtractLetters(string[] words)
        {
            int maxWordLength = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (maxWordLength < words[i].Length)
                {
                    maxWordLength = words[i].Length;
                }
            }

            for (int i = 0; i < maxWordLength; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j];

                    if (i < currentWord.Length)
                    {
                        int index = currentWord.Length - 1 - i;
                        result.Append(currentWord[index]);
                    }
                }
            }

            return result;
        }

        private static string MoveLetters(StringBuilder strangeCombinationOfLetters)
        {
            for (int i = 0; i < strangeCombinationOfLetters.Length; i++)
            {
                char currentSymbol = strangeCombinationOfLetters[i];
                int transition = char.ToLower(currentSymbol) - 'a' + 1;

                int nextPosition = (i + transition) % strangeCombinationOfLetters.Length;
                strangeCombinationOfLetters.Remove(i, 1);
                strangeCombinationOfLetters.Insert(nextPosition, currentSymbol);
            }

            return strangeCombinationOfLetters.ToString();
        }

        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder strangeCombinationOfLetters = ExtractLetters(words);
            string finalResult = MoveLetters(strangeCombinationOfLetters);

            Console.WriteLine(finalResult);
        }
    }
}
