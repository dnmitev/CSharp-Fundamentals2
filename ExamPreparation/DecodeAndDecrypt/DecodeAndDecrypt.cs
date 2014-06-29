// BGCoder: http://bgcoder.com/Contests/Practice/Index/94#3

namespace DecodeAndDecrypt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DecodeAndDecrypt
    {
        private static List<int> digits;

        private static void Main()
        {
            string input = Console.ReadLine();

            // Get the length of cypher
            int lengthOfCypher = GetCypherLength(input);

            // Encode(Encrypt(message, cypher) + cypher)
            var encodedMessage = input.Substring(0, input.Length - digits.Count);

            // Encrypt(message, cypher) + cypher
            var decodedMessage = Decode(encodedMessage);

            // Encrypt(message, cypher)
            var encryptedMessage = decodedMessage.Substring(0, decodedMessage.Length - lengthOfCypher);

            // cypher
            var cypher = decodedMessage.Substring(decodedMessage.Length - lengthOfCypher, lengthOfCypher);

            var result = Encrypt(encryptedMessage, cypher);

            Console.WriteLine(result);
        }

        private static int GetCypherLength(string input)
        {
            digits = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Add(input[i] - '0');
                }
                else
                {
                    break;
                }
            }

            digits.Reverse();

            int lengthOfCypher = 0;

            foreach (var digit in digits)
            {
                lengthOfCypher *= 10;
                lengthOfCypher += digit;
            }

            return lengthOfCypher;
        }

        private static string Decode(string encodedMessage)
        {
            StringBuilder result = new StringBuilder();

            int count = 0;

            foreach (var ch in encodedMessage)
            {
                if (char.IsDigit(ch))
                {
                    count *= 10;
                    count += (ch - '0');
                }
                else
                {
                    if (count == 0)
                    {
                        result.Append(ch);
                    }
                    else
                    {
                        result.Append(ch, count);
                        count = 0;
                    }
                }
            }

            return result.ToString();
        }

        private static string Encrypt(string message, string cypher)
        {
            string result = string.Empty;

            if (message.Length > cypher.Length)
            {
                result = EncryptWithLongerMessage(message, cypher);
            }
            else
            {
                result = EncryptWithLongerCypher(message, cypher);
            }

            return result;
        }

        private static string EncryptWithLongerCypher(string message, string cypher)
        {
            StringBuilder result = new StringBuilder(message);

            int messageIndex = 0;

            for (int i = 0; i < cypher.Length; i++)
            {
                char messageSymbol = result[messageIndex];
                char cypherSymbol = cypher[i];
                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

                result[messageIndex] = encryptedSymbol;

                messageIndex++;

                if (messageIndex == message.Length)
                {
                    messageIndex = 0;
                }
            }

            return result.ToString();
        }

        private static string EncryptWithLongerMessage(string message, string cypher)
        {
            StringBuilder result = new StringBuilder();

            int cypherIndex = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char messageSymbol = message[i];
                char cypherSymbol = cypher[cypherIndex];
                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

                result.Append(encryptedSymbol);

                cypherIndex++;

                if (cypherIndex == cypher.Length)
                {
                    cypherIndex = 0;
                }
            }

            return result.ToString();
        }

        private static char EncryptSymbol(char messageSymbol, char cypherSymbol)
        {
            int messageSymbolCode = messageSymbol - 'A';
            int cypherSymbolCode = cypherSymbol - 'A';

            int xoredSymbol = messageSymbolCode ^ cypherSymbolCode;
            char encrypted = (char)(xoredSymbol + 'A');

            return encrypted;
        }
    }
}