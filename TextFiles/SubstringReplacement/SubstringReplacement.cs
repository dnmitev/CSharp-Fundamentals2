// 7. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
// Ensure it will work with large files (e.g. 100 MB).

namespace SubstringReplacement
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class SubstringReplacement
    {
        private static void Main()
        {
            // get the encoding
            Encoding encoding = Encoding.UTF8;

            try
            {
                // initialize a new StreamReader
                StreamReader reader = new StreamReader(@"..\..\sample.txt", encoding);

                // print it in a file
                StreamWriter output = new StreamWriter(@"..\..\output.txt", false, encoding);

                ChangeSubstringInFile(reader, output);

                // print adequate massage on the console
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Output file successfully generated. Check \\TextFiles\\SubstringReplacement");
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

        private static void ChangeSubstringInFile(StreamReader reader, StreamWriter output)
        {
            using (reader)
            {
                using (output)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        output.WriteLine(line.Replace("start", "finish"));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}