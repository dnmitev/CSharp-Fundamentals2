// 4. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

namespace SubstringInText
{
    using System;
    using System.Linq;

    public class SubstringInText
    {
        private static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string pattern = "in";

            int count = 0;
            int index = text.IndexOf(pattern, StringComparison.CurrentCultureIgnoreCase);

            while (index != -1)
            {
                index = text.IndexOf(pattern, index + 1, StringComparison.CurrentCultureIgnoreCase);
                count++;
            }

            Console.WriteLine("{0} is contained {1} times in the text", pattern, count);
        }
    }
}