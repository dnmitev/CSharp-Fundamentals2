// 10. Write a program that extracts from given XML file all the text without the tags. 

namespace XMLTextExtraction
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class XMLTextExtraction
    {
        private static void Main()
        {
            // get the encoding
            Encoding encoding = Encoding.UTF8;

            try
            {
                StreamReader reader = new StreamReader(@"..\..\sample.xml", encoding);

                ReadFileWithotTags(reader);
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

        private static void ReadFileWithotTags(StreamReader reader)
        {
            using (reader)
            {
                // declare strings to store the file content and the pattern to be searched
                string fileContents = reader.ReadToEnd();
                string pattern = @"(?<=^`|>)[^><]+?(?=<|$)";

                Match match = Regex.Match(fileContents, pattern);

                while (match.Success)
                {
                    Console.Write(match);
                    match = match.NextMatch();
                }
            }
        }
    }
}