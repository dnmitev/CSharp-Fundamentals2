// 3.Write a program to convert decimal numbers to their hexadecimal representation.

namespace Dec2Hex
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Dec2Hex
    {
        private static void Main()
        {
            Console.Write("Please enter a decimal number: ");
            int decNum = int.Parse(Console.ReadLine());

            char[] result = Convert2Hex(decNum);
            Console.WriteLine("The hexadecimal representation is: {0}", string.Join("", result.Reverse()));
        }

        private static char[] Convert2Hex(int decNum)
        {
            char[] hexSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            StringBuilder hexNum = new StringBuilder();

            while (decNum != 0)
            {
                hexNum.Append(hexSymbols[decNum % 16]);
                decNum = decNum / 16;
            }

            return hexNum.ToString().ToCharArray();
        }
    }
}