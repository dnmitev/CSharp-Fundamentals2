// 12. Write a program that removes from a text file all words listed in given another text file. 
// Handle all possible exceptions in your methods.

namespace WordChanging
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class WordChanging
    {
        // get the encoding
        private static readonly Encoding encoding = Encoding.UTF8;

        private static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader(@"..\..\sample.txt", encoding);

                DeleteWords(ReadFileContent(reader));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Deleting successfully executed. Check \\TextFiles\\WordChanging.");
            }
            catch (FileNotFoundException exc)
            {
                Console.Error.WriteLine("Cannot find '{0}' file.", exc.FileName);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private static void DeleteWords(string content)
        {
            StreamWriter output = new StreamWriter(@"..\..\sample.txt", false, encoding);
            string pattern = string.Format("{0}{1}{2}", @"\b(", String.Join("|", File.ReadAllLines(@"..\..\words.txt")), @")\b");

            using (output)
            {
                output.WriteLine(Regex.Replace(content, pattern, string.Empty));
            }
        }

        private static string ReadFileContent(StreamReader reader)
        {
            using (reader)
            {
                string content = reader.ReadToEnd();
                return content;
            }
        }
    }
}