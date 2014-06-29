// 15. Write a program that replaces in a HTML document given as string 
// all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 

// http://gskinner.com/RegExr/

namespace HTMLTagsReplacement
{
    using System;

    public class HTMLTagsReplacement
    {
        static void Main()
        {
            string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            
            string replacedTags = text.Replace(@"<a href=""", "[URL=");
            replacedTags=replacedTags.Replace(@"</a>", @"[/URL]");
            replacedTags = replacedTags.Replace(@""">", "]");

            Console.WriteLine(replacedTags);
        }
    }
}
