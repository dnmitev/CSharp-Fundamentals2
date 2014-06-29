// BGCoder: http://bgcoder.com/Contests/Practice/Index/52#2

namespace Slides
{
    using System;
    using System.Linq;

    internal class Slides
    {
        private static int width, depth, heigth;
        private static string[, ,] cube;
        private static Ball cubeBall;

        private static void Main()
        {
            ReadInputData();
            ProcessBallCommands();
        }

        private static void ProcessBallCommands()
        {
            while (true)
            {
                string currCell = cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];

                string[] splitedCell = currCell.Split();

                string command = splitedCell[0];

                switch (command)
                {
                    case "S":
                        ProccessBallSlides(splitedCell[1]);
                        break;
                    case "T":
                        cubeBall.BallWidth = int.Parse(splitedCell[1]);
                        cubeBall.BallDepth = int.Parse(splitedCell[2]);
                        break;
                    case "B":
                        PrintMessage();
                        return;
                    case "E":
                        if (cubeBall.BallHeight == heigth - 1)
                        {
                            PrintMessage();
                            return;
                        }
                        else
                        {
                            cubeBall.BallHeight++;
                        }
                        break;
                    default:
                        throw new ArgumentException("Invalid command");
                }
            }
        }

        private static void ProccessBallSlides(string command)
        {
            Ball newCubeBall = new Ball(cubeBall);

            switch (command)
            {
                case "R":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallWidth++;
                    break;
                case "L":
                    newCubeBall.BallWidth--;
                    newCubeBall.BallHeight++;
                    break;
                case "F":
                    newCubeBall.BallDepth--;
                    newCubeBall.BallHeight++;
                    break;
                case "B":
                    newCubeBall.BallDepth++;
                    newCubeBall.BallHeight++;
                    break;
                case "FL":
                    newCubeBall.BallDepth--;
                    newCubeBall.BallWidth--;
                    newCubeBall.BallHeight++;
                    break;
                case "FR":
                    newCubeBall.BallDepth--;
                    newCubeBall.BallWidth++;
                    newCubeBall.BallHeight++;
                    break;
                case "BL":
                    newCubeBall.BallDepth++;
                    newCubeBall.BallWidth--;
                    newCubeBall.BallHeight++;
                    break;
                case "BR":
                    newCubeBall.BallDepth++;
                    newCubeBall.BallWidth++;
                    newCubeBall.BallHeight++;
                    break;
                default:
                    throw new ArgumentException("Ivalid slide command");
            }

            if (IsPassable(newCubeBall))
            {
                cubeBall = new Ball(newCubeBall);
            }
            else
            {
                PrintMessage();
                Environment.Exit(0);
            }
        }

        private static void PrintMessage()
        {
            string currentCell =
               cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];


            if (currentCell == "B" || cubeBall.BallHeight != heigth - 1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }

            Console.WriteLine("{0} {1} {2}", cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth);
        }

        private static bool IsPassable(Ball ball)
        {
            if (ball.BallWidth >= 0 && ball.BallHeight >= 0 && ball.BallDepth >= 0 &&
                ball.BallWidth < width && ball.BallHeight < heigth && ball.BallDepth < depth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ReadInputData()
        {
            string[] rawInput = Console.ReadLine().Split();

            width = int.Parse(rawInput[0]);
            heigth = int.Parse(rawInput[1]);
            depth = int.Parse(rawInput[2]);

            cube = new string[width, heigth, depth];

            for (int h = 0; h < heigth; h++)
            {
                string[] lineFragment = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                for (int d = 0; d < depth; d++)
                {
                    string[] cubeContents = lineFragment[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContents[w];
                    }
                }
            }

            string[] rawBallCoords = Console.ReadLine().Split();

            int ballWidth = int.Parse(rawBallCoords[0]);
            int ballDepth = int.Parse(rawBallCoords[1]);

            cubeBall = new Ball(ballWidth, 0, ballDepth);
        }
    }
}