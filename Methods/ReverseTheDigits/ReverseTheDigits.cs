// 7. Write a method that reverses the digits of given decimal number. Example: 256 -> 652

namespace ReverseTheDigits
{
    using System;
    using System.Linq;

    internal class ReverseTheDigits
    {
        private static void Main()
        {
            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();

            DigitReverse(number);
        }

        private static void DigitReverse(string number)
        {
            char[] digitInNumber = number.ToCharArray();
            char[] reversedDigits = new char[digitInNumber.Length];

            for (int i = 0; i < digitInNumber.Length; i++)
            {
                reversedDigits[i] = digitInNumber[digitInNumber.Length - i - 1];
            }

            Console.WriteLine("The reversed number is: {0}", string.Join("", reversedDigits));
        }
    }
}