// 9. * Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format
// Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

namespace FloatingPointNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class FloatingPointNumber
    {
        private static void Main()
        {
            Console.Write("Please enter a 32bit signed floating point number: ");
            float floatingPointNum = float.Parse(Console.ReadLine());

            int sign = 0;
            sign = GetSign(floatingPointNum);
            Console.WriteLine("Sign = {0}", sign);

            string exponent = string.Empty;
            exponent = GetExponent(floatingPointNum);
            Console.WriteLine("Exponent = {0}", exponent);

            List<int> mantissa = new List<int>();
            mantissa = GetMantissa(floatingPointNum);
            Console.WriteLine("Mantissa = {0}", string.Join(string.Empty, mantissa));
        }

        private static string GetExponent(float number)
        {
            number = Math.Abs(number);

            // get the binary representation of the number
            string binary = Convert.ToString((int)number, 2);

            // number's length + 127 - 1 is the decimal expression of the exponent
            int exponent = binary.Length - 1 + 127;

            // get the binary expression of the exponent
            string stringExponent = Convert.ToString(exponent, 2);

            return stringExponent;
        }

        private static List<int> GetMantissa(float number)
        {
            List<int> mantissa = new List<int>();

            number = Math.Abs(number);

            // get the whole part
            int firstPart = (int)number;
            while (firstPart >= 2)
            {
                mantissa.Add(firstPart % 2);
                firstPart /= 2;
            }

            // reverse it to be true
            mantissa.Reverse();

            // get the fractional part
            float secondPart = number % 1;
            while (secondPart != 0.0)
            {
                if (2 * secondPart >= 1)
                {
                    mantissa.Add(1);
                }
                else
                {
                    mantissa.Add(0);
                }

                secondPart = (2 * secondPart) % 1;
            }

            // add zeros to the 23rd bit
            while (mantissa.Count < 23)
            {
                mantissa.Add(0);
            }

            return mantissa;
        }

        private static int GetSign(float argument)
        {
            int sign = 0;

            if (argument < 0)
            {
                sign = 1;
            }

            return sign;
        }
    }
}