// 9. Write a program that deletes from given text file all odd lines. The result should be in the same file.

namespace OddLinesDeleting
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    class OddLinesDeleting
    {

        static void Main()
        {
            try
            {
                string[] lines = GetLinesFromFile();
                DeleteOddLinesFromFile(lines);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Odd lines successfully deleted. Check \\TextFiles\\OddLinesDeleting");
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

        private static string[] GetLinesFromFile()
        {
            // get the encoding
            Encoding encoding = Encoding.UTF8;

            using (StreamReader reader = new StreamReader(@"..\..\sample.txt", encoding))
            {
                string[] content = reader.ReadToEnd().Split('\n');
                return content;
            }
        }

        private static void DeleteOddLinesFromFile(string[] content)
        {
            // get the encoding
            Encoding encoding = Encoding.UTF8;

            using (StreamWriter output = new StreamWriter(@"..\..\sample.txt", false, encoding))
            {
                for (int i = 0; i < content.Length; i++)
                {
                    if (((i + 1) & 1) == 1)
                    {
                        output.WriteLine("{0} \n", content[i]);
                    }
                }
            }
        }
    }
}
