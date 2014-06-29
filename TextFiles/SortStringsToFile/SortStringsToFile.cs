// 6.Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
namespace SortStringsToFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    class SortStringsToFile
    {
        static void Main()
        {
            // get the encoding
            Encoding encoding = Encoding.UTF8;

            try
            {
                // initialize a new StreamReader
                StreamReader reader = new StreamReader(@"..\..\sample.txt", encoding);

                List<string> fileContent = new List<string>();
                fileContent = GetStringsFromFile(reader);
                fileContent.Sort();

                // print it in a file
                StreamWriter output = new StreamWriter(@"..\..\outputFile.txt", false, encoding);
                PrintResultToFile(output, fileContent);


                // print adequate massage on the console
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Output file successfully generated. Check \\TextFiles\\SortStringsToFilee");
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

        private static List<string> GetStringsFromFile(StreamReader reader)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                List<string> lines = new List<string>();

                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }

                return lines;
            }
        }

        private static void PrintResultToFile(StreamWriter output, List<string> result)
        {
            using (output)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    output.WriteLine(result[i]);
                }
            }
        }
    }
}
