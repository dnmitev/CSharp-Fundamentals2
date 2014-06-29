// BGCoder: http://bgcoder.com/Contests/Practice/Index/52#0

namespace KaspichanNumbers
{
    using System;
    using System.Text;

    class KaspichanNumbers
    {
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            // if the entered number is zero, the Answer is A
            if (number == 0)
            {
                Console.WriteLine(letters[0]);
                return;
            }

            StringBuilder sb = new StringBuilder();

            // don't provide answer for number = 0
            while (number != 0)
            {
                int digit = (int)(number % 256);
                number = number / 256;

                string kaspichanDigit = GetKaspichanDigit(digit);

                sb.Insert(0, kaspichanDigit);
            }

            Console.WriteLine(sb.ToString());
        }

        private static string GetKaspichanDigit(int digit)
        {
            string kaspichanDigit = string.Empty;

            if (digit >= 0 && digit <= 25)
            {
                kaspichanDigit = letters[digit].ToString();
            }
            else if (digit >= 26 && digit <= 51)
            {
                kaspichanDigit = "a" + letters[digit - 26].ToString();
            }
            else if (digit >= 52 && digit <= 77)
            {
                kaspichanDigit = "b" + letters[digit - 52].ToString();
            }
            else if (digit >= 78 && digit <= 103)
            {
                kaspichanDigit = "c" + letters[digit - 78].ToString();
            }
            else if (digit >= 104 && digit <= 129)
            {
                kaspichanDigit = "d" + letters[digit - 104].ToString();
            }
            else if (digit >= 130 && digit <= 155)
            {
                kaspichanDigit = "e" + letters[digit - 130].ToString();
            }
            else if (digit >= 156 && digit <= 181)
            {
                kaspichanDigit = "f" + letters[digit - 156].ToString();
            }
            else if (digit >= 182 && digit <= 207)
            {
                kaspichanDigit = "g" + letters[digit - 182].ToString();
            }
            else if (digit >= 208 && digit <= 233)
            {
                kaspichanDigit = "h" + letters[digit - 208].ToString();
            }
            else if (digit >= 234 && digit <= 255)
            {
                kaspichanDigit = "i" + letters[digit - 234].ToString();
            }

            return kaspichanDigit;
        }
    }
}

