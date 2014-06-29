namespace HelpDoge
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    internal class HelpDoge
    {
        private static int xFood;
        private static int yFood;

        private static int xPosEnemy;
        private static int yPosEnemy;

        private static int pathCount = 0;

        private static char[,] lab;

        private static int n;
        private static int m;

        private static void Main()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            string[] dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(dimensions[0]);
            m = int.Parse(dimensions[1]);

            string[] food = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            xFood = int.Parse(food[0]);
            yFood = int.Parse(food[1]);

            int enemies = int.Parse(Console.ReadLine());
            lab = new char[n, m];

            for (int i = 0; i < enemies; i++)
            {
                string[] enemyPosition = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                xPosEnemy = int.Parse(enemyPosition[0]);
                yPosEnemy = int.Parse(enemyPosition[1]);

                lab[xPosEnemy, yPosEnemy] = '*';
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (lab[i, j] != '*')
                    {
                        if (i == xFood && j == yFood)
                        {
                            lab[i, j] = 'e';
                        }
                        else
                        {
                            lab[i, j] = ' ';
                        }
                    }
                }
            }

            FindPath(0, 0);
            Console.WriteLine(pathCount);

            sw.Stop();

            Console.WriteLine(sw.Elapsed);
        }

        private static void FindPath(int row, int col)
        {
            if ((col < 0) || (row < 0) ||
                (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth
                return;
            }

            // Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                pathCount++;
            }

            if (lab[row, col] != ' ')
            {
                // The current cell is not free
                return;
            }

            // Mark the current cell as visited
            lab[row, col] = 's';

            // Invoke recursion to explore all possible directions
            //FindPath(row, col - 1); // left
            //FindPath(row - 1, col); // up
            FindPath(row, col + 1); // right
            FindPath(row + 1, col); // down

            // Mark back the current cell as free
            lab[row, col] = ' ';
        }
    }
}