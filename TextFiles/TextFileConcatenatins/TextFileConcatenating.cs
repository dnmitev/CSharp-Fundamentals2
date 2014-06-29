// 2. Write a program that concatenates two text files into another text file.

namespace TextFileConcatenatins
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class TextFileConcatenating
    {
        private static void Main()
        {
            try
            {
                // get the correct encoding
                Encoding encoding = Encoding.GetEncoding(1251);

                // initialize StreamReaders
                StreamReader firstReader = new StreamReader(@"..\..\firstSample.txt", encoding);
                StreamReader secondReader = new StreamReader(@"..\..\secondSample.txt", encoding);

                // initialize StreamWriter
                StreamWriter output = new StreamWriter(@"..\..\outputFile.txt", false, encoding);

                // declare strings to store the file contents and assign them with the contents
                string firstFileContent = ReadFile(firstReader);
                string secondFileContent = ReadFile(secondReader);

                // call the WriteToFile method to store the strings into the output file
                WriteToFile(output, firstFileContent, secondFileContent);

                // print user friendly massage in order not be cursed for not printing it 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The output file generated. Please check the directory \\TextFiles\\TextFileConcatenatins");
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

        private static void WriteToFile(StreamWriter output, string firstFileContent, string secondFileContent)
        {
            using (output)
            {
                output.WriteLine(firstFileContent);
                output.WriteLine();
                output.WriteLine(secondFileContent);
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