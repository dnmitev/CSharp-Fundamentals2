// BGCoder: http://bgcoder.com/Contests/Practice/Index/54#0

namespace DurankulakNumbers
{
    using System;
    using System.Linq;
    using System.Text;

    internal class DurankulakNumbers
    {
        private static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder modifiedInput = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'f')
                {
                    modifiedInput.AppendFormat("{0} ", input.Substring(i, 2));
                    i++;
                }
                else
                {
                    modifiedInput.AppendFormat("{0} ", input.Substring(i, 1));
                }
            }

            string hackInput = modifiedInput.ToString();

            string[] digits = hackInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            ulong result = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                int powerIndex = digits.Length - i - 1;

                int number = GetDurankulakDigits(digits[i]);

                result += ((ulong)number * Power(168, powerIndex));
            }

            Console.WriteLine(result);
        }

        private static int GetDurankulakDigits(string durankulakDigit)
        {
            int number = 0;

            if (durankulakDigit[0] >= 'A' && durankulakDigit[0] <= 'Z')
            {
                number = (durankulakDigit[0] - 'A');
            }
            else if (durankulakDigit.Length == 2 && durankulakDigit[0] == 'a' && durankulakDigit[1] >= 'A' && durankulakDigit[1] <= 'Z')
            {
                number = (durankulakDigit[1] - 'A' + 26);
            }
            else if (durankulakDigit.Length == 2 && durankulakDigit[0] == 'b' && durankulakDigit[1] >= 'A' && durankulakDigit[1] <= 'Z')
            {
                number = (durankulakDigit[1] - 'A' + 52);
            }
            else if (durankulakDigit.Length == 2 && durankulakDigit[0] == 'c' && durankulakDigit[1] >= 'A' && durankulakDigit[1] <= 'Z')
            {
                number = (durankulakDigit[1] - 'A' + 78);
            }
            else if (durankulakDigit.Length == 2 && durankulakDigit[0] == 'd' && durankulakDigit[1] >= 'A' && durankulakDigit[1] <= 'Z')
            {
                number = (durankulakDigit[1] - 'A' + 104);
            }
            else if (durankulakDigit.Length == 2 && durankulakDigit[0] == 'e' && durankulakDigit[1] >= 'A' && durankulakDigit[1] <= 'Z')
            {
                number = (durankulakDigit[1] - 'A' + 130);
            }
            else if (durankulakDigit.Length == 2 && durankulakDigit[0] == 'f' && durankulakDigit[1] >= 'A' && durankulakDigit[1] <= 'L')
            {
                number = (durankulakDigit[1] - 'A' + 156);
            }

            return number;
        }

        private static ulong Power(ulong powerBase, int power)
        {
            ulong powered = powerBase;

            if (power != 0)
            {
                for (int powIndex = 1; powIndex < power; powIndex++)
                {
                    powered *= powerBase;
                }
            }
            else
            {
                return 1;
            }

            return powered;
        }
    }
}