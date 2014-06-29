// 3. Write a program that reads a text file and inserts line numbers in front of each of its lines. 
// The result should be written to another text file.

namespace LineNumberInserting
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class LineNumberInserting
    {
        private static void Main()
        {
            // get the encoding
            Encoding encoding = Encoding.UTF8;

            try
            {
                // initialize a new StreamReader
                StreamReader reader = new StreamReader(@"..\..\sample.txt", encoding);

                // initialize a new StreamWriter
                StreamWriter output = new StreamWriter(@"..\..\outputFile.txt", false, encoding);

                // get the file content splitted by new lines into string array
                string[] fileContent = ReadFile(reader).Split('\n');

                // put numeration the the file lines
                NumberLinesIntoFile(output, fileContent);

                // print not curse provoking massage 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lines successfully numbered. Check \\TextFiles\\LineNumberInserting to see the output file.");
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

        private static void NumberLinesIntoFile(StreamWriter output, string[] contentByLine)
        {
            using (output)
            {
                for (int i = 0; i < contentByLine.Length; i++)
                {
                    output.WriteLine("{0} : {1}", i + 1, contentByLine[i]);
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