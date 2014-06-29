// 6.Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace Bin2Hex
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Bin2Hex
    {
        private static void Main()
        {
            Console.Write("Please enter a binary number: ");
            string binary = Console.ReadLine();

            // add 0 (zeros) in front to be sure that the number has exaxt four digits or more four divisible count
            int fourDivLength = 0;
            fourDivLength = binary.Length + (4 - binary.Length % 4);
            binary = binary.PadLeft(fourDivLength, '0');

            string result = ConvertBin2Hex(binary.TrimStart('0'));
            Console.WriteLine("The hexadecimal expression is: {0}", result);
        }

        private static string ConvertBin2Hex(string binary)
        {
            string[] binaryRepresentation =
            {
                "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"
            };

            char[] hexSymbols =
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'
            };

            StringBuilder hexadecimal = new StringBuilder();
            StringBuilder binFourth = new StringBuilder();

            for (int i = 0; i <= binary.Length - 4; i += 4)
            {
                for (int j = i; j < i + 4; j++)
                {
                    binFourth.Append(binary[j]);
                }

                int index = Array.IndexOf(binaryRepresentation, binFourth.ToString());
                hexadecimal.Append(hexSymbols[index]);

                binFourth.Clear();
            }

            return hexadecimal.ToString();
        }
    }
}