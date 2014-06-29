// BGCoder: http://bgcoder.com/Contests/Practice/Index/55#2

namespace KukataIsDancing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class KukataIsDancing
    {
        private static void Main()
        {
            Dictionary<char, string> colors = new Dictionary<char, string>();

            colors.Add('R', "RED");
            colors.Add('G', "GREEN");
            colors.Add('B', "BLUE");

            char[,] dancefloor = 
            {
                { 'R', 'B', 'R' },
                { 'B', 'G', 'B' },
                { 'R', 'B', 'R' },
            };

            StringBuilder moves = new StringBuilder();

            int danceCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < danceCount; i++)
            {
                int row = 1;
                int col = 1;

                string dance = Console.ReadLine();

                GetKukataDancing(dance, ref row, ref col);

                moves.Append(dancefloor[row, col]);
            }

            for (int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine(colors[moves[i]]);
            }
        }

        private static void GetKukataDancing(string dance, ref int row, ref int col)
        {
            bool left = false;
            bool right = false;
            bool up = true;
            bool down = false;

            for (int j = 0; j < dance.Length; j++)
            {
                switch (dance[j])
                {
                    case 'W':
                        if (left)
                        {
                            if (col > 0)
                            {
                                col--;
                            }
                            else
                            {
                                col = 2;
                            }
                        }

                        if (up)
                        {
                            if (row > 0)
                            {
                                row--;
                            }
                            else
                            {
                                row = 2;
                            }
                        }

                        if (down)
                        {
                            if (row < 2)
                            {
                                row++;
                            }
                            else
                            {
                                row = 0;
                            }
                        }

                        if (right)
                        {
                            if (col < 2)
                            {
                                col++;
                            }
                            else
                            {
                                col = 0;
                            }
                        }
                        break;
                    case 'L':
                        if (up)
                        {
                            left = true;
                            right = false;
                            down = false;
                            up = false;
                            break;
                        }

                        if (down)
                        {
                            right = true;
                            up = false;
                            left = false;
                            down = false;
                            break;
                        }

                        if (left)
                        {
                            down = true;
                            up = false;
                            left = false;
                            right = false;
                            break;
                        }

                        if (right)
                        {
                            up = true;
                            down = false;
                            left = false;
                            right = false;
                        }

                        break;
                    case 'R':
                        if (up)
                        {
                            right = true;
                            up = false;
                            left = false;
                            down = false;
                            break;
                        }

                        if (down)
                        {
                            left = true;
                            right = false;
                            up = false;
                            down = false;
                            break;
                        }

                        if (left)
                        {
                            up = true;
                            down = false;
                            left = false;
                            right = false;
                            break;
                        }

                        if (right)
                        {
                            down = true;
                            up = false;
                            left = false;
                            right = false;
                            break;
                        }

                        break;
                    default:
                        throw new ArgumentException("Kukata cant dance this!");
                }
            }
        }
    }
}