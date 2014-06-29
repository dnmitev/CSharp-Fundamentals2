// 12. Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements.

// http://gskinner.com/RegExr/

namespace URLAddressParsing
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class URLAddressParsing
    {
        private static void Main()
        {
            string address = "http://www.devbg.org/forum/index.php ";
            string pattern = @"\s*(?<protocol>\w*?)\:[\\/]{2}(?<server>[^\\/]*)[\\/](?<resource>[^\s,;]*)";

            MatchCollection matches = Regex.Matches(address, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine("[protocol]: {0}", match.Groups["protocol"].Value);
                Console.WriteLine("[server]: {0}", match.Groups["server"].Value);
                Console.WriteLine("[resource] {0}", match.Groups["resource"].Value);
            }
        }
    }
}