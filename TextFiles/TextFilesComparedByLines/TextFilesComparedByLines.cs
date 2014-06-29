// 4. Write a program that compares two text files line by line and prints the number of lines 
// that are the same and the number of lines that are different. 
// Assume the files have equal number of lines.

namespace TextFilesComparedByLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class TextFilesComparedByLines
    {
        private static void Main()
        {
            // get the encoding
            Encoding encoding = Encoding.UTF8;

            try
            {
                // initialize new StreamReaders
                StreamReader firstReader = new StreamReader(@"..\..\firstSample.txt", encoding);
                StreamReader secondReader = new StreamReader(@"..\..\secondSample.txt", encoding);

                // initialize a new StreamWriter
                StreamWriter output = new StreamWriter(@"..\..\outputFile.txt", false, encoding);

                // compare the 2 files
                CompareTextFilesByLines(firstReader, secondReader);
            }
            catch (FileNotFoundException exc)
            {
                Console.Error.WriteLine("Cannot find '{0}' file.", exc.FileName);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot open file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.Error.WriteLine("There is no access to write files.");
            }
        }

        private static void CompareTextFilesByLines(StreamReader firstReader, StreamReader secondReader)
        {
            using (firstReader)
            {
                using (secondReader)
                {
                    // get the file contents splitted by new lines into string arrays
                    string[] firstFileContent = ReadFile(firstReader).Split('\n');
                    string[] secondFileContent = ReadFile(secondReader).Split('\n');

                    int sameCount = 0;
                    int differentCount = 0;

                    for (int i = 0; i < firstFileContent.Length; i++)
                    {
                        if (string.Compare(firstFileContent[i], secondFileContent[i]) == 0)
                        {
                            sameCount++;
                        }
                        else
                        {
                            differentCount++;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Equal lines count is {0}", sameCount);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Different lines count is {0}", differentCount);
                }
            }
        }

        private static string ReadFile(StreamReader reader)
        {
            string content = string.Empty;

            using (reader)
            {
                content = reader.ReadToEnd();
            }

            return content;
        }
    }
}