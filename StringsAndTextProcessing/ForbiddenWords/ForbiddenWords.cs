// 9. We are given a string containing a list of forbidden words and a text containing some of these words. 
// Write a program that replaces the forbidden words with asterisks. 

// http://gskinner.com/RegExr/

namespace ForbiddenWords
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ForbiddenWords
    {
        private static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string pattern = @"(?<forbiddenWords>\b(PHP|CLR|Microsoft)\b)";

            Console.WriteLine(Regex.Replace(text, pattern, m => new string('*', m.Length)));
        }
    }
}