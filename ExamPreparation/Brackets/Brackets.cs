﻿// BGCOder: http://bgcoder.com/Contests/Practice/Index/54#3

namespace Brackets
{
    using System;
    using System.Text;

    class Brackets
    {
        static StringBuilder sb = new StringBuilder();

        static string tabs;
        static int tabsCount = 0;

        static bool shouldPrintNewLine = false;
        static bool isFirstSymbol = true;


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            tabs = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine().Trim();

                HandleLine(line);
            }

            Console.WriteLine(sb);
        }

        private static void HandleLine(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (shouldPrintNewLine)
                {
                    sb.AppendLine();
                    shouldPrintNewLine = false;
                    isFirstSymbol = true;
                }

                char currentChar = line[i];

                if (currentChar == '{')
                {
                    if (!shouldPrintNewLine)
                    {
                        if (!isFirstSymbol)
                        {
                            if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                            {
                                sb.Remove(sb.Length - 1, 1);
                            }

                            sb.AppendLine();
                        }
                    }

                    AppendTabs();
                    sb.Append(currentChar);
                    tabsCount++;
                    shouldPrintNewLine = true;
                }
                else if (currentChar == '}')
                {
                    tabsCount--;

                    if (!shouldPrintNewLine)
                    {
                        if (!isFirstSymbol)
                        {
                            if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                            {
                                sb.Remove(sb.Length - 1, 1);
                            }

                            sb.AppendLine();
                        }
                    }

                    AppendTabs();
                    sb.Append(currentChar);
                    shouldPrintNewLine = true;
                }
                else
                {
                    if (isFirstSymbol)
                    {
                        AppendTabs();
                    }

                    if (!(isFirstSymbol && char.IsWhiteSpace(currentChar)))
                    {
                        if (!(i < line.Length - 1 && char.IsWhiteSpace(line[i]) && char.IsWhiteSpace(line[i + 1])))
                        {
                            sb.Append(currentChar);
                        }
                    }

                    isFirstSymbol = false;
                }
            }

            shouldPrintNewLine = true;
            isFirstSymbol = true;
        }

        private static void AppendTabs()
        {
            for (int i = 0; i < tabsCount; i++)
            {
                sb.Append(tabs);
            }
        }
    }
}