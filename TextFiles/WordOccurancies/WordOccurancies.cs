// 13. Write a program that reads a list of words from a file words.txt and finds 
// how many times each of the words is contained in another file test.txt. .
// The result should be written in the file result.txt and the words should be sorted by the number 
// of their occurrences in descending order. Handle all possible exceptions in your methods.

namespace WordOccurancies
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class WordOccurancies
    {
        // get the encoding
        private static readonly Encoding encoding = Encoding.UTF8;

        // declare a dictionary collection visible for all of the methods used
        private static readonly Dictionary<string, int> dictionary = new Dictionary<string, int>();

        private static void Main()
        {
            try
            {
                GetWordsFromFile();
                GetWordsCountInFile();
                StoreSortedResultIntoFile();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully executed. Check \\TextFiles\\WordOccurancies");
            }
            catch (FileNotFoundException exc)
            {
                Console.Error.WriteLine("Cannot find '{0}' file.", exc.FileName);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private static void StoreSortedResultIntoFile()
        {
            using (StreamWriter result = new StreamWriter(@"..\..\result.txt", false, encoding))
            {
                foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                {
                    result.Write(wordCounter.Key);
                    result.Write(" : ");
                    result.WriteLine(wordCounter.Value);
                }
            }
        }

        private static void GetWordsCountInFile()
        {
            using (StreamReader reader = new StreamReader(@"..\..\test.txt", encoding))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    List<string> wordList = new List<string>(dictionary.Keys);

                    foreach (var word in wordList)
                    {
                        string pattern = string.Format(@"\b{0}\b", word);

                        MatchCollection matches = Regex.Matches(line, pattern);

                        dictionary[word] += matches.Count;
                    }

                    line = reader.ReadLine();
                }
            }
        }

        private static void GetWordsFromFile()
        {
            using (StreamReader reader = new StreamReader(@"..\..\words.txt", encoding))
            {
                string word = reader.ReadLine();

                while (word != null)
                {
                    dictionary.Add(word, 0);
                    word = reader.ReadLine();
                }
            }
        }
    }
}