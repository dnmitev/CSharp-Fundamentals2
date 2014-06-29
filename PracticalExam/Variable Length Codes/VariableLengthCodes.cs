namespace VariableLengthCodes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class VariableLengthCodes
    {
        static Dictionary<string, int> codeTable = new Dictionary<string, int>();

        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string modified = line.Insert(1, "@");

                GetDictionaryData(modified);
            }

            string binaryCode = GetInputToBinary(input);

            string decrypted = DecryptBinary(binaryCode);

            Console.WriteLine(decrypted);
        }

        private static string DecryptBinary(string binaryCode)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < binaryCode.Length; i++)
            {
                int onesCount = 0;

                for (int j = i; j < binaryCode.Length; j++)
                {
                    if (binaryCode[j] == '1')
                    {
                        onesCount++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

                foreach (var value in codeTable)
                {
                    if (onesCount == value.Value)
                    {
                        result.Append(value.Key);
                    }
                }
            }

            return result.ToString();
        }

        private static void GetDictionaryData(string line)
        {
            string[] splitted = line.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            string character = splitted[0];
            int count = int.Parse(splitted[1]);

            codeTable.Add(character, count);
        }

        private static string GetInputToBinary(string[] input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int number = int.Parse(input[i]);

                string binary = Convert.ToString(number, 2);

                result.Append(binary.PadLeft(8, '0'));
            }

            return result.ToString();
        }
    }
}
