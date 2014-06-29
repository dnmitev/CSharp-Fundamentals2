namespace TRES4Numbers
{
    using System;
    using System.Text;

    class TRES4Numbers
    {
        static void Main()
        {
            ulong input = ulong.Parse(Console.ReadLine());

            string result = GetTRES4Number(input);

            Console.WriteLine(result);
        }

        private static string GetTRES4Number(ulong number)
        {
            StringBuilder result = new StringBuilder();

            if (number == 0)
            {
                result.Insert(0, "LON+");
            }

            while (number != 0)
            {
                int digit = (int)(number % 9);
                number = number / 9;

                string TRES4Digit = GetTRES4Digit(digit);

                result.Insert(0, TRES4Digit);
            }

            return result.ToString();
        }

        private static string GetTRES4Digit(int digit)
        {
            string TRES4Digit = string.Empty;

            switch (digit)
            {
                case 0:
                    TRES4Digit = "LON+";
                    break;
                case 1:
                    TRES4Digit = "VK-";
                    break;
                case 2:
                    TRES4Digit = "*ACAD";
                    break;
                case 3:
                    TRES4Digit = "^MIM";
                    break;
                case 4:
                    TRES4Digit = "ERIK|";
                    break;
                case 5:
                    TRES4Digit = "SEY&";
                    break;
                case 6:
                    TRES4Digit = "EMY>>";
                    break;
                case 7:
                    TRES4Digit = "/TEL";
                    break;
                case 8:
                    TRES4Digit = "<<DON";
                    break;
                default:
                    throw new ArgumentException("Check logic for 1-9 TRES4 digits!");
            }

            return TRES4Digit;
        }
    }
}