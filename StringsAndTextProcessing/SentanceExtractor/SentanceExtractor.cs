// 8. Write a program that extracts from a given text all sentences containing given word.

// http://gskinner.com/RegExr/

namespace SentanceExtractor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class SentanceExtractor
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string givenWord = "in";

            string pattern = @"\s*(?<sentence>[^\.]*?\b" + givenWord + @"\b(.|\s)*?\.)";

            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["sentence"].Value);
            }
        }
    }
}
