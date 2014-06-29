// BGCoder: http://bgcoder.com/Contests/Practice/Index/94#4

namespace FeaturingWithGrisko
{
    using System;
    using System.Linq;

    public class FeaturingWithGrisko
    {
        private static bool NextPermutation(char[] charList)
        {
            /*
            Knuth's algorothm
            1. Find the largest index j such that a[j] < a[j + 1]. If no such index exists, the permutation is the last permutation.
            2. Find the largest index l such that a[j] < a[l]. Since j + 1 is such an index, l is well defined and satisfies j < l.
            3. Swap a[j] with a[l].
            4. Reverse the sequence from a[j + 1] up to and including the final element a[n].
            * !!! NOTE: The algorithm works with lexicographically sorted values
            */
            var largestIndex = -1;

            for (var i = charList.Length - 2; i >= 0; i--)
            {
                if (charList[i] < charList[i + 1])
                {
                    largestIndex = i;
                    break;
                }
            }

            if (largestIndex < 0)
            {
                return false;
            }

            var largestIndex2 = -1;
            for (var i = charList.Length - 1; i >= 0; i--)
            {
                if (charList[largestIndex] < charList[i])
                {
                    largestIndex2 = i;
                    break;
                }
            }

            var tmp = charList[largestIndex];
            charList[largestIndex] = charList[largestIndex2];
            charList[largestIndex2] = tmp;

            for (int i = largestIndex + 1, j = charList.Length - 1; i < j; i++, j--)
            {
                tmp = charList[i];
                charList[i] = charList[j];
                charList[j] = tmp;
            }

            return true;
        }

        private static bool IsValid(char[] letters)
        {
            char previous = letters[0];

            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i] == previous)
                {
                    return false;
                }

                previous = letters[i];
            }

            return true;
        }

        private static void Main()
        {
            string input = Console.ReadLine().ToLower();

            char[] letters = input.ToCharArray();

            Array.Sort(letters);

            int counter = 0;

            if (IsValid(letters))
            {
                counter++;
            }

            while (NextPermutation(letters))
            {
                if (IsValid(letters))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}