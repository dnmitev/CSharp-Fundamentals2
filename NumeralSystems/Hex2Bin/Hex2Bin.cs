// 5. Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace Hex2Bin
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Hex2Bin
    {
        private static void Main()
        {
            Console.Write("Please enter a hexadecimal number: ");
            string hexadecimal = Console.ReadLine();

            // make all letters capital 
            hexadecimal = hexadecimal.ToUpper();

            Console.WriteLine("The decimal expression is: {0}", ConvertHex2Bin(hexadecimal));
        }

        private static string ConvertHex2Bin(string hexadecimal)
        {
            char[] hexSymbols =
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'
            };

            string[] binaryRepresent =
            {
                "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"
            };

            StringBuilder binary = new StringBuilder();

            for (int i = 0; i < hexadecimal.Length; i++)
            {
                int index = Array.IndexOf(hexSymbols, hexadecimal[i]);
                binary.Append(binaryRepresent[index]);
            }

            return binary.ToString();
        }
    }
}