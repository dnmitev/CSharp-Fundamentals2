// 25. Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 

// http://gskinner.com/RegExr/

namespace BodyAndTitleExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class BodyAndTitleExtractor
    {
        static void Main()
        {
            string text =
                        @"<html>
                            <head><title>News</title></head>
                            <body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body>
                         </html>";
            string pattern = @"(?<=^`|>)[^><]+?(?=<|$)";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
