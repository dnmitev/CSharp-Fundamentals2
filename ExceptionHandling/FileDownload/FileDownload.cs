// 4. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
// and stores it the current directory. Find in Google how to download files in C#. 
// Be sure to catch all exceptions and to free any used resources in the finally block.

namespace FileDownload
{
    using System;
    using System.Net;

    internal class FileDownload
    {
        private static void Main()
        {
            // enter the URL as a string
            Console.Write("Please enter URL: ");
            string webAddress = Console.ReadLine();

            // enter the file name of the downloaded file
            Console.Write("Please enter a file name: ");
            string file = Console.ReadLine();

            // create a new WebClient
            WebClient client = new WebClient();

            try
            {
                client.DownloadFile(webAddress, file);
                Console.WriteLine("Download complete! Check bin/debug/ to see the file.");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid web address.");
            }
            finally
            {
                // dispose the Web Client no matter if the upper code can be executed
                client.Dispose();
            }
        }
    }
}