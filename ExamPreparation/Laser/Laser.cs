// BGCoder: http://bgcoder.com/Contests/Practice/Index/54#2

namespace Laser
{
    using System;
    using System.Linq;

    public class Laser
    {
        private static void Main()
        {
            int[] dims = ParseTheInput();
            int[] pos = ParseTheInput();
            int[] vect = ParseTheInput();

            bool[,,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2] + 1];

            while (true)
            {
                visited[pos[0], pos[1], pos[2]] = true;

                int[] newPosition = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    newPosition[i] = pos[i] + vect[i];
                }

                // check whether the position is already visited
                if (visited[newPosition[0], newPosition[1], newPosition[2]] || GetCubeBounds(newPosition, dims) >= 2)
                {
                    Console.WriteLine("{0} {1} {2}", pos[0], pos[1], pos[2]);
                    return;
                }

                if (GetCubeBounds(newPosition, dims) == 1) // wall hitted, laser is reflected
                {
                    ReverseComponents(newPosition, vect, dims);
                }

                for (int i = 0; i < 3; i++)
                {
                    pos[i] = newPosition[i];
                }
            }
        }

        private static void ReverseComponents(int[] newPosition, int[] vect, int[] dims)
        {
            for (int i = 0; i < 3; i++)
            {
                if (newPosition[i] == 1 && vect[i] == -1)
                {
                    vect[i] *= -1;
                }
                else if (newPosition[i] == dims[i] && vect[i] == 1)
                {
                    vect[i] *= -1;
                }
            }
        }

        private static int GetCubeBounds(int[] pos, int[] dims)
        {
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                if (pos[i] == 1 || pos[i] == dims[i])
                {
                    count++;
                }
            }

            return count;
        }

        private static int[] ParseTheInput()
        {
            string input = Console.ReadLine();

            string[] splittedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[splittedInput.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(splittedInput[i]);
            }

            return numbers;
        }
    }
}