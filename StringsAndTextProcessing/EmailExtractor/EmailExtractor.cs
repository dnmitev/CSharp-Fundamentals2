// 18. Write a program for extracting all email addresses from given text. All substrings that match 
// the format <identifier>@<host>…<domain> should be recognized as emails

// http://gskinner.com/RegExr/

namespace EmailExtractor
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class EmailExtractor
    {
        static void Main()
        {
            string text = "Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string pattern = @"([\w-+\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
