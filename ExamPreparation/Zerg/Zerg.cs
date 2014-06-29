// BG Coder: http://bgcoder.com/Contests/Practice/Index/95#0

namespace Zerg
{
    using System;
    using System.Linq;

    internal class Zerg
    {
        private static void Main()
        {
            ulong number = 0;

            string[] zergCode = 
            {
                "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh"
            };

            string input = Console.ReadLine();

            int p = 0;

            for (int i = 0; i <= input.Length - 4; i += 4)
            {
                string currentCode = string.Empty;
                p++;

                for (int j = i; j < i + 4; j++)
                {
                    currentCode += input[j];
                }

                int code = Array.IndexOf(zergCode, currentCode);
                int power = input.Length / 4 - p;

                number = number + (ulong)(code * (Math.Pow(15, power)));
            }

            Console.WriteLine(number);
        }
    }
}