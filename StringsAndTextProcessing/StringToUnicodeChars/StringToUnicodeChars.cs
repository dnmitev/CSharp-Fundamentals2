// 10. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

namespace StringToUnicodeChars
{
    using System;
    using System.Linq;

    public class StringToUnicodeChars
    {
        private static void Main()
        {
            string input = "Hi!";

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(string.Format("\\u{0:x4}", (uint)input[i]));
            }

            Console.WriteLine();
        }
    }
}