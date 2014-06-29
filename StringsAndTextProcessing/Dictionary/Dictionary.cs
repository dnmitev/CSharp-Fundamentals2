// 14.A dictionary is stored as a sequence of text lines containing words and their explanations. 
// Write a program that enters a word and translates it by using the dictionary. 

// http://gskinner.com/RegExr/

namespace Dictionary
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Dictionary
    {
        private static void Main()
        {
            string dictionary = @".NET - platform for applications from Microsoft 
                                  CLR - managed execution environment for .NET 
                                  namespace - hierarchical organization of classes";

            string searchWord = "clr";
            string pattern = string.Format("{0}{1}", searchWord, @"(\s+?)\-(\s+?)(?<definition>((.|\s)*?))\r");

            MatchCollection matches = Regex.Matches(dictionary, pattern, RegexOptions.IgnoreCase);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine("{0} : {1}", searchWord.ToUpper(), match.Groups["definition"]);
                }
            }
            else
            {
                Console.WriteLine("The word is not in the dictionary.");
            }
        }
    }
}