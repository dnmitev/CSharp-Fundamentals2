// BGCoder: http://bgcoder.com/Contests/Practice/Index/94#0

namespace MultiverseCommunication
{
    using System;

    class MultiverseCommunication
    {
        static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            ulong result = 0;
            int counter = 0;

            for (int i = 0; i < input.Length - 2; i += 3)
            {
                counter++;
                ulong current = 0;
                int power = input.Length / 3 - counter;

                string strangeDigit = input.Substring(i, 3);

                int num = GetNumber(strangeDigit);

                current = (ulong)(num * Math.Pow(13, power));
                result += current;
            }

            Console.WriteLine(result);
        }

        public static int GetNumber(string str)
        {
            switch (str)
            {
                case "CHU": return 0;
                case "TEL": return 1;
                case "OFT": return 2;
                case "IVA": return 3;
                case "EMY": return 4;
                case "VNB": return 5;
                case "POQ": return 6;
                case "ERI": return 7;
                case "CAD": return 8;
                case "K-A": return 9;
                case "IIA": return 10;
                case "YLO": return 11;
                case "PLA": return 12;

                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }
        }
    }
}
