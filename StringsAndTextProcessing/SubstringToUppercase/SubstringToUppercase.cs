// 5.You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> 
// and </upcase> to uppercase. The tags cannot be nested. 

// http://gskinner.com/RegExr/ check regex pattern

namespace SubstringToUppercase
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SubstringToUppercase
    {
        private static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string pattern = @"<upcase>(?<capitalize>(.|\s)*?)</upcase>";
            
            Console.WriteLine(Regex.Replace(text, pattern, m => m.Groups["capitalize"].Value.ToUpper()));
        }
    }
}