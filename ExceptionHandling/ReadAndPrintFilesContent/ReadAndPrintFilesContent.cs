// 3. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
// Be sure to catch all possible exceptions and print user-friendly error messages.

namespace ReadAndPrintFilesContent
{
    using System;
    using System.IO;
    using System.Text;

    internal class ReadAndPrintFilesContent
    {
        private static void Main()
        {
            try
            {
                Console.Write("Enter the full path of the file you want to use: ");
                string filePath = Console.ReadLine();

                ReadFile(filePath);
            }
            catch (Exception exc)
            {
                // I am using the given Microsoft error massages for working with files
                Console.WriteLine(exc.Message);
            }
        }

        private static void ReadFile(string filePath)
        {
            // declare a string to store the file's content, take care of the encoding
            string fileContents = File.ReadAllText(filePath, Encoding.GetEncoding(1251));

            Console.WriteLine("The file content is: ");
            Console.WriteLine(fileContents);
        }
    }
}