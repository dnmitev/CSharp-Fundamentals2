// 11.Write a program that deletes from a text file all words that start with the prefix "test". 
// Words contain only the symbols 0...9, a...z, A…Z, _.

namespace TestPrefixWordsDeleted
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class TestPrefixWordsDeleted
    {
        // get the encoding
        private static readonly Encoding encoding = Encoding.UTF8;

        private static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader(@"..\..\sample.txt", encoding);

                DeleteWordsFromFile(ReadFileContent(reader));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Deleting successfully executed. Check \\TextFiles\\TestPrefixWordsDeleted.");
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

        private static void DeleteWordsFromFile(string content)
        {
            StreamWriter output = new StreamWriter(@"..\..\sample.txt", false, encoding);

            using (output)
            {
                string pattern = @"(\b)test((\d|\w|_)*)(\b)";
                output.WriteLine(Regex.Replace(content, pattern, string.Empty));
            }
        }

        private static string ReadFileContent(StreamReader reader)
        {
            using (reader)
            {
                StringBuilder content = new StringBuilder();
                string line = reader.ReadLine();

                while (line != null)
                {
                    content.Append(line);
                    line = reader.ReadLine();
                }

                return content.ToString();
            }
        }
    }
}