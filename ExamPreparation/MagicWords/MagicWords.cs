// BGCoder: http://bgcoder.com/Contests/Practice/Index/94#1

namespace MagicWords
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class MagicWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentWord = Console.ReadLine();
                words.Add(currentWord);
            }

            for (int i = 0; i < words.Count; i++)
            {
                string temp = words[i];
                int newPosition = words[i].Length % (words.Count + 1);

                words[i] = null;
                words.Insert(newPosition, temp);
                words.Remove(null);
            }

            int maxLength = 0;

            for (int i = 0; i < words.Count; i++)
            {
                if (maxLength < words[i].Length)
                {
                    maxLength = words[i].Length;
                }
            }

            StringBuilder result = new StringBuilder();

            for (int index = 0; index < maxLength; index++)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (index < words[i].Length)
                    {
                        result.Append(words[i][index]);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
