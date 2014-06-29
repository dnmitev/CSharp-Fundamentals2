// 8. Modify the solution of the previous problem to replace only whole words (not substrings).

namespace WholeWordsReplacement
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class WholeWordsReplacement
    {
        static void Main(string[] args)
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
                Console.WriteLine("Output file successfully generated. Check \\TextFiles\\WholeWordsReplacement");
     
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
                        output.WriteLine(Regex.Replace(line, "\\bstart\\b", "finish"));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

