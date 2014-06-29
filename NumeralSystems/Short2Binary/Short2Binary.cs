// 8. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace Short2Binary
{
    using System;
    using System.Linq;

    internal class Short2Binary
    {
        private static void Main()
        {
            Random rndShort = new Random();

            short number = (short) rndShort.Next(short.MinValue, short.MaxValue + 1);

            Console.WriteLine("16bit signed integer as decimal: {0}", number);

            string result = ConvertToBinary(number).PadLeft(15, '0');

            // put 1 or 0 on the leading bit position for negative or positve number
            if (number > 0)
            {
                Console.WriteLine("And has a binary representation: 0{0}", result);
            }
            else
            {
                Console.WriteLine("And has a binary representation: 1{0}", result);
            }
        }

        private static string ConvertToBinary(int number)
        {
            string binary = string.Empty;

            if (number < 0)
            {
                number *= (-1);
            }

            while (number != 0)
            {
                binary = string.Format("{0}{1}", number % 2, binary);
                number /= 2;
            }

            return binary;
        }
    }
}