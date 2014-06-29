// BGCoder: http://bgcoder.com/Contests/Practice/Index/54#1

namespace JoroTheRabbit
{
    using System;

    class JoroTheRabbit
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] terrain = new int[input.Length];

            for (int i = 0; i < terrain.Length; i++)
            {
                terrain[i] = int.Parse(input[i]);
            }

            int bestLength = int.MinValue;

            for (int start = 0; start < terrain.Length; start++)
            {
                for (int step = 1; step < terrain.Length; step++)
                {
                    int previousJump = start;
                    int currLength = 1;
                    int nextJump = (previousJump + step) % terrain.Length;

                    while (nextJump != previousJump && terrain[previousJump] < terrain[nextJump])
                    {
                        currLength++;
                        previousJump = nextJump;
                        nextJump = (previousJump + step) % terrain.Length;
                    }

                    if (bestLength < currLength)
                    {
                        bestLength = currLength;
                    }
                }
            }

            Console.WriteLine(bestLength);
        }
    }
}
