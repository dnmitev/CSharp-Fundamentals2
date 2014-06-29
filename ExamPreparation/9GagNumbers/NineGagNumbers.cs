// BGCoder: http://bgcoder.com/Contests/Practice/Index/55#0

namespace NineGagNumbers
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class NineGagNumbers
    {
        private static string ConvertNineGagToNumber(string digit)
        {
            string result = "NO";

            switch (digit)
            {
                case "-!":
                    return result = "0";
                case "**":
                    return result = "1";
                case "!!!":
                    return result = "2";
                case "&&":
                    return result = "3";
                case "&-":
                    return result = "4";
                case "!-":
                    return result = "5";
                case "*!!!":
                    return result = "6";
                case "&*!":
                    return result = "7";
                case "!!**!-":
                    return result = "8";
                default:
                    break;
            }

            return result;
        }

        private static string GetNineBasedNumber(string input)
        {
            string partialInput = string.Empty;
            string nineBasedNumber = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                partialInput += input[i];

                string currentDigit = ConvertNineGagToNumber(partialInput);

                if (currentDigit != "NO")
                {
                    nineBasedNumber += currentDigit;
                    partialInput = string.Empty;
                }
            }

            return nineBasedNumber;
        }

        private static BigInteger GetNineBased2TenBased(string nineBasedNumber)
        {
            BigInteger result = 0;

            for (int i = 0; i < nineBasedNumber.Length; i++)
            {
                int currDigit = nineBasedNumber[i] - '0';
                int power = nineBasedNumber.Length - i - 1;

                result += (currDigit * BigInteger.Pow(9, power));
            }

            return result;
        }

        private static void Main()
        {
            string input = Console.ReadLine();

            string nineBasedNumber = GetNineBasedNumber(input);

            BigInteger result = GetNineBased2TenBased(nineBasedNumber);

            Console.WriteLine(result);
        }
    }
}