// 1. Write a program that reads a text file and prints on the console its odd lines.

namespace PrintOddFileLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class PrintOddFileLines
    {
        private static void Main()
        {
            // be sure of the encoding
            Encoding encoding = Encoding.UTF8;

            try
            {
                // get new StreamReader
                StreamReader reader = new StreamReader(@"..\..\sample.txt", encoding);

                // use the reader and print the odd lines
                PrintOddLines(reader);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Cannot find the file.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot open the file.");
            }
        }

        private static void PrintOddLines(StreamReader reader)
        {
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    if ((lineNumber & 1) == 0)
                    {
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}